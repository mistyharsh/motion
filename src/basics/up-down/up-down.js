import { $Id, } from '../../util.js';
import { Ball } from './ball.js';

window.addEventListener('DOMContentLoaded', () => {

    const canvas = $Id('canvas');
    const context = canvas.getContext('2d');

    const ball = new Ball(40, 'brown');

    // Animation variable
    let angle = 0;

    ball.x = canvas.width / 2;
    ball.y = canvas.height / 2;

    (function drawFrame() {

        window.requestAnimationFrame(drawFrame);
        context.clearRect(0, 0, canvas.width, canvas.height);

        ball.y = (canvas.height / 2) + Math.sin(angle) * 100;
        angle += 0.1;

        ball.draw(context);
    })();

}, false);