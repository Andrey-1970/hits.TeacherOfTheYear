document.addEventListener('DOMContentLoaded', () => {
    const cropArea = document.getElementById('crop-area');

    let isResizing = false;

    cropArea.addEventListener('wheel', function (event) {
        event.preventDefault();
        const scale = event.deltaY < 0 ? 1.05 : 0.95;
        const newWidth = cropArea.offsetWidth * scale;
        const newHeight = newWidth / (3 / 4);  // соотношение сторон 3:4

        cropArea.style.width = `${newWidth}px`;
        cropArea.style.height = `${newHeight}px`;
    });

    cropArea.addEventListener('mousedown', function (event) {
        if (!isResizing) {
            const rect = cropArea.getBoundingClientRect();
            const offsetX = event.clientX - rect.left;
            const offsetY = event.clientY - rect.top;

            function onMouseMove(mouseMoveEvent) {
                cropArea.style.left = `${mouseMoveEvent.clientX - offsetX}px`;
                cropArea.style.top = `${mouseMoveEvent.clientY - offsetY}px`;
            }

            function onMouseUp() {
                document.removeEventListener('mousemove', onMouseMove);
                document.removeEventListener('mouseup', onMouseUp);
            }

            document.addEventListener('mousemove', onMouseMove);
            document.addEventListener('mouseup', onMouseUp);
        }
    });
});

window.getCropData = () => {
    const cropArea = document.getElementById('crop-area');
    const image = document.getElementById('uploadedImage');

    const cropRect = cropArea.getBoundingClientRect();
    const imageRect = image.getBoundingClientRect();

    return {
        X: cropRect.left - imageRect.left,
        Y: cropRect.top - imageRect.top,
        Width: cropRect.width,
        Height: cropRect.height
    };
};