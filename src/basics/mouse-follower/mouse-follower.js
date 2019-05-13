import { Arrow } from '../rotate-to-mouse/arrow.js';
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

  const speed = 2;

  function drawFrame() {

    window.requestAnimationFrame(drawFrame);

    context.clearRect(0, 0, canvas.width, canvas.height);

    const dx = mouse.x - arrow.x;
    const dy = mouse.y - arrow.y;

    // Angle in radiance
    const angle = Math.atan2(dy, dx);

    const vx = Math.cos(angle) * speed;
    const vy = Math.sin(angle) * speed;

    arrow.rotation = angle;
    arrow.x += vx;
    arrow.y += vy;

    arrow.draw(context);
  }

  // Run the animation loop
  drawFrame();

});