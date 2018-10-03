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
${dogen} -t Models/dia/LAMModel.dia ${dogen_options}
${dogen} -t Models/dia/CSharpModel.dia ${dogen_options}

#
# Code generate from json models
#
# ${dogen} -t Models/json/LAMModel.json ${dogen_options}
# ${dogen} -t Models/json/CSharpModel.json ${dogen_options}
