#!/bin/bash

tailwindPath="/usr/bin/tailwindcss"
appStylesPathIn="./Styles/app.css"
appStylesPathOut="./wwwroot/app.css"

if ! pgrep tailwindcss > /dev/null; then
  $tailwindPath -i $appStylesPathIn -o $appStylesPathOut --watch
fi