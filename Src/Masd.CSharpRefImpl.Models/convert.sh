#!/bin/bash

#
# Very quick hack to get Dogen to convert models. This needs to be
# productionised and integrated with MSBuild.
#

#
# Ensure we have the expected number of arguments.
#
if [ $# != 1 ]; then
    echo "USAGE: DOGEN_BINARY" >&2
    exit 0;
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
model_dir="${script_dir}/../Masd.CSharpRefImpl.Models";
dogen_log_dir="${script_dir}/log";

#
# Dogen options.
#
dogen_general_options="--log-enabled --log-level trace";
dogen_general_options="${dogen_general_options} --log-directory ${dogen_log_dir}";

#
# Convert all models
#
frontend="dia"
models="`'ls' ${model_dir}/${frontend}/*.${frontend}`";
for model in ${models}; do
    echo "Converting ${model}";
    dogen_source_option="--source ${model}";
    dogen_destination_option="--destination ${model}.json";
    ${dogen_binary} convert ${dogen_general_options} ${dogen_source_option} ${dogen_destination_option}
    mv ${model_dir}/dia/*.json ${model_dir}/json/
done
