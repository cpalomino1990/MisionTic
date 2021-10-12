var ui = $( "#orangeUI" ),
    h = $( window ).height(),
    elemHH = ui.height() / 2;

ui.css( "margin-top", h / 2 - elemHH );

function onResize() {
  h = $( window ).height();

  ui.css( "margin-top", h / 2 - elemHH );
}

$( window ).on( "resize", onResize );
