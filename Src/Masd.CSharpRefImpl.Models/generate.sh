#!/bin/bash

#
# Very quick hack to get Dogen to generate the models. This needs to
# be productionised and integrated with MSBuild.
#

#
# Ensure we have the expected number of arguments.
#
if [ $# != 2 ]; then
    echo "USAGE: FRONTEND DOGEN_BINARY" >&2
    echo "Valid frontends: json, dia." >&2
    exit 0;
fi

#
# Handle frontend argument.
#
frontend=$1;
shift;
if [ $frontend = "json" ]; then
    echo "Using JSON frontend."
elif [ $frontend = "dia" ]; then
    echo "Using Dia frontend."
else
    echo "Invalid frontend: '${frontend}'." >&2
fi

#
# Handle dogen binary argument.
#
dogen_binary=$1;
if [ ! -f ${dogen_binary} ]; then
    echo "Could not find dogen binary."
    exit 0;
fi

#
# Get script directory.
#
script_dir="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null && pwd )";
dogen_output_dir="${script_dir}/../";
model_dir="${script_dir}/../Masd.CSharpRefImpl.Models";
dogen_log_dir="${script_dir}/log";

#
# Dogen options. Using --force-write due to a bug at present, needs to
# be removed once fixed.
#
dogen_general_options="--log-level trace";
dogen_general_options="${dogen_general_options} --output-directory ${dogen_output_dir}";
dogen_general_options="${dogen_general_options} --log-directory ${dogen_log_dir}";

#
# Code generate all models
#
models="`'ls' ${model_dir}/${frontend}/*.${frontend}`";
for model in ${models}; do
    echo "Generating ${model}";
    dogen_target_option="--target ${model}";
    ${dogen_binary} ${dogen_target_option} ${dogen_general_options}
done
