document.addEventListener("DOMContentLoaded", function () {
    const ctx = document.getElementById("myChart");

    if (ctx) {
        new Chart(ctx, {
            type: 'line',
            data: {
                labels: ["Ocak", "�ubat", "Mart", "Nisan", "May�s"],
                datasets: [{
                    label: 'Sat��lar',
                    data: [12, 19, 3, 5, 2],
                    borderWidth: 1
                }]
            },
            options: {
                responsive: true
            }
        });
    } else {
        console.error("myChart bulunamad� DOM'da.");
    }

});
