// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function myFunction(artist)
{
    $.ajax({
        url: "https://musicbrainz.org/ws/2/artist/?query=" + artist.value + "&limit=5&fmt=json",
        type: 'GET',
        complete: function (result) {
            if (result.readyState == 4 && result.status == 200)
            {
                alert("State : " + result.readyState + " - Status : " + result.status);
                alert(result.responseText);
                var arr = JSON.parse(result.responseText);
                //$.ajaxSettings.traditional = true;
                $.ajax(
                    {
                        url: 'Supply/GetArtistsCard',
                        type: 'Post',
                        data: JSON.stringify(arr.artists),
                        contentType: 'application/json; charset=utf-8',
                        complete: function (ArtistCard) {
                            alert("State : " + ArtistCard.readyState + " - Status : " + ArtistCard.status);
                            alert(ArtistCard.responseText);
                            $("#response").html(ArtistCard.responseText)
                        }
                    });
            }
        },
        error: function (resultat, statut, erreur) {
            alert("Erreur : " + erreur);
        }
    });
}