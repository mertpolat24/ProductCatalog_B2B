document.addEventListener("DOMContentLoaded", function () {
    var ctx = document.getElementById("myAreaChart");
    if (!ctx) return; // DOM'da yoksa çizim yapma

    var myAreaChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun"],
            datasets: [{
                label: "Earnings",
                data: [0, 10000, 5000, 15000, 10000, 20000],
                backgroundColor: "rgba(78, 115, 223, 0.05)",
                borderColor: "rgba(78, 115, 223, 1)",
            }],
        },
        options: {
            maintainAspectRatio: false,
            scales: {
                xAxes: [{ time: { unit: 'date' }, gridLines: { display: false } }],
                yAxes: [{
                    ticks: { beginAtZero: true },
                    gridLines: { color: "rgba(234, 236, 244, 1)" }
                }]
            },
            legend: { display: false }
        }
    });
});
