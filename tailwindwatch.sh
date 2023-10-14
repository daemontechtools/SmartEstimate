#!/bin/bash

if [ "$ASPNETCORE_ENVIRONMENT" == "Production" ]; then
  appStylesPathIn="./Styles/main.production.css"
else
  appStylesPathIn="./Styles/main.development.css"
fi

appStylesPathOut="./wwwroot/css/bundle.css"


if ! pgrep tailwindcss > /dev/null; then
  nohup $TAILWINDCSS -i $appStylesPathIn -o $appStylesPathOut --watch > /dev/null 2>&1 &
fi