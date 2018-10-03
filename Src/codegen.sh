#!/bin/sh

#
# Very quick hack to get Dogen to generate the models. This needs to
# be productionised and integrated with MSBuild.
#

if [ $# != 1 ]; then
    echo "Expected path to dogen binary."
    exit 0;
fi

dogen=$1;
if [ ! -f ${dogen} ]; then
    echo "Could not find dogen binary."
    exit 0;
fi

# Using -f due to a bug at present, needs to be removed once fixed.
dogen_options="-f -d";

#
# Code generate from dia models
#
dia_models="`'ls' Models/dia/*.dia`";
for dia_model in ${dia_models}; do
    echo "Generating ${dia_model}";
    ${dogen} -t ${dia_model} ${dogen_options}
done

#
# Code generate from json models
#
# json_models="`'ls' Models/json/*.json`";
# for json_model in ${json_models}; do
#     echo "Generating ${json_model}";
#     ${dogen} -t ${json_model} ${dogen_options}
# done
