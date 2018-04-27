
export class Ball {

    constructor(radius, color) {
        this.x = 0;
        this.y = 0;
        this.radius = radius;

        this.rotation = 0;
        this.scaleX = 1;
        this.scaleY = 1;

        this.color = color;
        this.lineWidth = 1;
    }

    draw(context) {
        context.save();

        // Translate origin to make it simple to draw circle
        context.translate(this.x, this.y);
        context.rotate(this.rotation);
        context.scale(this.scaleX, this.scaleY);

        context.lineWidth = this.lineWidth;
        context.fillStyle = this.color;

        context.beginPath();
        //x, y, radius, start_angle, end_angle, anti-clockwise
        context.arc(0, 0, this.radius, 0, (Math.PI * 2), true);
        context.closePath();
        context.fill();

        if (this.lineWidth > 0) {
            context.stroke();
        }

        context.restore();
    }

}