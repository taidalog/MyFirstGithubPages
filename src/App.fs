module App

open Browser.Dom

let rec f n =
    let myButton = document.getElementById("incr") :?> Browser.Types.HTMLButtonElement
    myButton.innerText <- sprintf "You clicked: %i time(s)" n
    myButton.onclick <- fun _ -> f (n + 1)

let myButton = document.getElementById("incr") :?> Browser.Types.HTMLButtonElement
myButton.onclick <- fun _ -> f 0
