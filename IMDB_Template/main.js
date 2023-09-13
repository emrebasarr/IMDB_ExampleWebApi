//selector $

$(document).ready(function()
{
    var apiUrl = "https://localhost:7171/api/movies/";
    var cards = $("#Cards");

    //AJAX
    $.ajax({
        url:apiUrl+"GetMovies",
        type:"Get",
        success:function(response)
        {
            GetMovieTable(response);
            console.log(response);
        },
        error:function(err)
        {
            if(err.status==404){
                alert("Veriler Bulunmadı!");
            }
        },
    })

    //Verileri tabloya dahil etme
    function GetMovieTable(data)
    {
        var cards=$("#Cards");
        data.forEach(function(val,index){
          cards.append(
            `
                <div class="card">
                    <img
                    src="images/placeholder.png"
                    class="card-img-top"
                    alt="..."
                    />
                    <div class="card-body">
                    <h5 class="card-title">Movie Title</h5>
                    <div class="d-flex justify-content-between">
                        <a href="#" class="nav-link">2023</a>
                        <a href="#" class="nav-link">70</a>
                    </div>
                    </div>
                </div> 
            `
          )     
        })
    }
})