document.addEventListener('DOMContentLoaded', () => {
    console.log("DOMContentLoaded event fired.");
    initPhotoEditor();
});

let cropRectangle;
let image;
let isDragging = false;
let startX, startY;

// Сброс состояния перед загрузкой нового изображения
function reset() {
    console.log("Resetting crop rectangle...");
    cropRectangle.style.display = 'none';
    cropRectangle.style.width = '0px';
    cropRectangle.style.height = '0px';
    cropRectangle.style.left = '0px';
    cropRectangle.style.top = '0px';
    isDragging = false;
}

function initPhotoEditor() {
    cropRectangle = document.getElementById('crop-rectangle');
    image = document.getElementById('uploaded-image');

    if (!cropRectangle || !image) {
        console.error("Required elements are not found in the DOM.");
        return;
    }

    cropRectangle.addEventListener('mousedown', startDragging);
    document.addEventListener('mousemove', drag);
    document.addEventListener('mouseup', stopDragging);
    document.addEventListener('wheel', resizeCropRectangle);
    console.log("Photo editor initialized");
}

function imageLoaded() {
    console.log("Image successfully loaded with natural dimensions:", image.naturalWidth, image.naturalHeight);
    adjustImageAndInitializeCrop();
}

function imageLoadError() {
    console.error("Failed to load image");
    alert("Error loading image! Please try again.");
}

function loadImage(imageDataUrl) {
    if (!image) {
        console.error("Image element not found in the DOM.");
        return;
    }

    reset();

    if (!imageDataUrl) {
        console.error("Received empty imageDataUrl");
        return;
    }

    image.onload = () => {
        console.log("Image has fully loaded");
        imageLoaded();
    };

    image.onerror = () => {
        console.error("Failed to load image");
        imageLoadError();
    };

    image.src = imageDataUrl;
    console.log("Setting image source to:", imageDataUrl);
    image.style.display = 'block';
}

function adjustImageAndInitializeCrop() {
    const aspectRatio = image.naturalWidth / image.naturalHeight;
    const container = image.parentElement;
    let containerWidth = container.clientWidth;
    let containerHeight = container.clientHeight;

    if (containerWidth / containerHeight > aspectRatio) {
        containerWidth = containerHeight * aspectRatio;
    } else {
        containerHeight = containerWidth / aspectRatio;
    }

    image.style.width = `${containerWidth}px`;
    image.style.height = `${containerHeight}px`;

    const initialSize = Math.min(containerWidth, containerHeight) / 2;

    cropRectangle.style.width = `${initialSize}px`;
    cropRectangle.style.height = `${initialSize * 4 / 3}px`;
    cropRectangle.style.left = `${(containerWidth - initialSize) / 2}px`;
    cropRectangle.style.top = `${(containerHeight - initialSize * 4 / 3) / 2}px`;
    cropRectangle.style.display = 'block';

    console.log("Crop rectangle initialized with dimensions:", cropRectangle.offsetWidth, cropRectangle.offsetHeight);
    console.log("Image container dimensions:", containerWidth, containerHeight);
    console.log("Crop rectangle position:", cropRectangle.style.left, cropRectangle.style.top);
}

function startDragging(e) {
    isDragging = true;
    startX = e.clientX - cropRectangle.offsetLeft;
    startY = e.clientY - cropRectangle.offsetTop;
    console.log("Dragging started at:", startX, startY);
}

function drag(e) {
    if (!isDragging) return;

    let newX = e.clientX - startX;
    let newY = e.clientY - startY;

    const maxX = image.offsetWidth - cropRectangle.offsetWidth;
    const maxY = image.offsetHeight - cropRectangle.offsetHeight;

    newX = Math.max(0, Math.min(newX, maxX));
    newY = Math.max(0, Math.min(newY, maxY));

    cropRectangle.style.left = `${newX}px`;
    cropRectangle.style.top = `${newY}px`;

    console.log("Dragging to:", newX, newY);
}

function stopDragging() {
    isDragging = false;
    console.log("Dragging stopped");
}

function resizeCropRectangle(e) {
    e.preventDefault();

    const delta = e.deltaY * -0.01;
    const currentWidth = cropRectangle.offsetWidth;
    const currentHeight = cropRectangle.offsetHeight;

    const newWidth = Math.max(50, Math.min(currentWidth + delta * 10, image.offsetWidth));
    const newHeight = newWidth * 4 / 3;

    if (newHeight > image.offsetHeight) return;

    cropRectangle.style.width = `${newWidth}px`;
    cropRectangle.style.height = `${newHeight}px`;

    const deltaX = (newWidth - currentWidth) / 2;
    const deltaY = (newHeight - currentHeight) / 2;

    let newLeft = cropRectangle.offsetLeft - deltaX;
    let newTop = cropRectangle.offsetTop - deltaY;

    newLeft = Math.max(0, Math.min(newLeft, image.offsetWidth - newWidth));
    newTop = Math.max(0, Math.min(newTop, image.offsetHeight - newHeight));

    cropRectangle.style.left = `${newLeft}px`;
    cropRectangle.style.top = `${newTop}px`;

    console.log("Resizing to:", newWidth, newHeight);
}

function getCropCoordinates() {
    const coordinates = {
        x: cropRectangle.offsetLeft,
        y: cropRectangle.offsetTop,
        width: cropRectangle.offsetWidth,
        height: cropRectangle.offsetHeight
    };
    console.log("Crop coordinates:", coordinates);
    return coordinates;
}
