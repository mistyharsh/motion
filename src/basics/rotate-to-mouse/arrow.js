export class Arrow {
    constructor() {
        this.x = 0;
        this.y = 0;

        this.color = '#FFFF00';
        this.rotation = 0;
    }

    draw(context) {
        context.save();

        // Here I am translating and rotating origin. Due to this translation,
        // I don't have to worry about arrow drawing calculations.
        context.translate(this.x, this.y);
        context.rotate(this.rotation);

        context.lineWidth = 2;
        context.fillStyle = this.color;

        context.beginPath();
        context.moveTo(-50, -25);
        context.lineTo(0, -25);
        context.lineTo(0, -50);
        context.lineTo(50, 0);
        context.lineTo(0, 50);
        context.lineTo(0, 25);
        context.lineTo(-50, 25);
        context.lineTo(-50, -25);
        context.closePath();
        context.fill();
        context.stroke();

        context.restore();
    }
}