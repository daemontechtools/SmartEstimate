#!/bin/bash

appStylesPathOut="./wwwroot/css/bundle.css"

if [ "$APP_MODE" == "Production" ]; then
  appStylesPathIn="./Styles/main.production.css"
  echo "Building for production"
  $TAILWINDCSS -i $appStylesPathIn -o $appStylesPathOut

else
  appStylesPathIn="./Styles/main.development.css"
  echo "Building for development"
  /usr/bin/tailwindcss -i $appStylesPathIn -o $appStylesPathOut
fi