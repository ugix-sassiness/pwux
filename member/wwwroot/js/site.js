// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    // initialize Swiper


// UI Animation
// Product Menu Navigation
let t1 = gsap.timeline({ paused: true, reversed: true });
let watch = false;
const mode = document.querySelector(".productmenu");

mode.addEventListener("click", (e) => {
    if (!watch) {
        t1.play();
        watch = true;
    } else {
        t1.reverse();
        watch = false;
    }
});

t1.to(
    ".productmenu",
    {
        ease: "back.inOut(1.7)",
        height: 198,
        y: -10,
    },
    0
);

t1.to(
    ".revealoffer",
    {
        ease: "power1.inOut",
        bottom: 40,
        opacity: 1,
    },
    0.5
);
t1.to(
    ".offericon",
    {
        ease: "power1.inOut",
        bottom: 0,
        opacity: 1,
    },
    0.85
);
