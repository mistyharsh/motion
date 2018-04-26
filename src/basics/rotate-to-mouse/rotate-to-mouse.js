import { Arrow } from './arrow.js';
import { $Id, captureMouse } from '../../util.js';

window.addEventListener('DOMContentLoaded', () => {

    // Access to canvas
    const canvas = $Id('canvas');
    const context = canvas.getContext('2d');

    // Make an arrow for canvas
    const arrow = new Arrow();
    arrow.x = canvas.width / 2;
    arrow.y = canvas.height / 2;

    const mouse = captureMouse(canvas);

    mouse.x = arrow.x;
    mouse.y = arrow.y;

    (function drawFrame() {

        window.requestAnimationFrame(drawFrame);
        // setTimeout(drawFrame, 2000);

        context.clearRect(0, 0, canvas.width, canvas.height);

        context.beginPath();
        context.moveTo(0, canvas.height / 2);
        context.lineTo(canvas.width, canvas.height / 2);
        context.stroke();
        context.closePath();

        const dx = mouse.x - arrow.x;
        const dy = mouse.y - arrow.y;

        // In Radiance
        // arrow.rotation = Math.atan(dy / dx);
        arrow.rotation = Math.atan2(dy, dx);

        arrow.draw(context);
    })();

}, false);