import { $Id } from '../../util.js';
import { Ball } from '../ball.js';

window.addEventListener('DOMContentLoaded', () => {

    const canvas = $Id('canvas');
    const context = canvas.getContext('2d');

    const ball = new Ball(40, 'brown');

    // Animation variable
    let angle = 0;

    // Trying to keep actual numbers out of motion code
    // The speed here is in radians to increment angle
    const speed = 0.05;
    const range = 100;

    ball.x = canvas.width / 2;
    ball.y = canvas.height / 2;

    (function drawFrame() {

        window.requestAnimationFrame(drawFrame);

        // wave fun when rect is not cleared
        context.clearRect(0, 0, canvas.width, canvas.height);

        ball.y = (canvas.height / 2) + Math.sin(angle) * range;
        angle += speed;

        ball.draw(context);
    })();

}, false);
