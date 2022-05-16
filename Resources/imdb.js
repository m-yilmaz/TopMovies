var movies = [];
$(".lister-list > div").each(function () {
    var id = $(this).find("[data-tconst]").first().data("tconst");
    var name = $(this).find("h3 > a").text();
    var year = Number($(this).find("h3 > span").last().text().substr(-5, 4));
    var rating = Number($(this).find(".ratings-bar strong").text());
    var imgUrl = $(this).find("img").attr("src");
    var genre = $(this).find(".genre").text().trim().toLowerCase();
    movies.push({ id, name, year, rating, imgUrl, genre });
});
console.log(JSON.stringify(movies));