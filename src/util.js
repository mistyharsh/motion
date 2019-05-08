
export function $Id(id) {
    return document.getElementById(id);
}

export function $One(selector) {
    return document.querySelector(selector);
}

export function $Many(selector) {
    return document.querySelectorAll(selector);
}

export function captureMouse(element) {

    const mouse = {
        x: 0,
        y: 0,
        stop() {
            element.removeEventListener('mousemove', listener);
        }
    };

    function listener(event) {
        mouse.x = event.pageX - element.offsetLeft;
        mouse.y = event.pageY - element.offsetTop;
    }

    element.addEventListener('mousemove', listener, false);

    return mouse;
}