document.addEventListener("DOMContentLoaded", function () {
    const ctx = document.getElementById("myChart");

    if (ctx) {
        new Chart(ctx, {
            type: 'line',
            data: {
                labels: ["Ocak", "Þubat", "Mart", "Nisan", "Mayýs"],
                datasets: [{
                    label: 'Satýþlar',
                    data: [12, 19, 3, 5, 2],
                    borderWidth: 1
                }]
            },
            options: {
                responsive: true
            }
        });
    } else {
        console.error("myChart bulunamadý DOM'da.");
    }

});
