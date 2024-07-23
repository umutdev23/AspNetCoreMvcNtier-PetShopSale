function lightenHexColor(hex, percent) {
    let r = parseInt(hex.slice(1, 3), 16);
    let g = parseInt(hex.slice(3, 5), 16);
    let b = parseInt(hex.slice(5, 7), 16);

    r = Math.min(255, Math.floor(r + (255 - r) * percent));
    g = Math.min(255, Math.floor(g + (255 - g) * percent));
    b = Math.min(255, Math.floor(b + (255 - b) * percent));

    return `#${(1 << 24 | r << 16 | g << 8 | b).toString(16).slice(1).toUpperCase()}`;
}

document.addEventListener('DOMContentLoaded', () => {
    document.querySelectorAll('.sidebar1').forEach(sidebar => {
        const hexColor = sidebar.getAttribute('data-color');
        const lightColor = lightenHexColor(hexColor, 0.3);
        sidebar.style.backgroundColor = lightColor;
    });
});