#!/bin/bash

#
# Very quick hack to get Dogen to convert models. This needs to be
# productionised and integrated with MSBuild.
#

#
# Ensure we have the expected number of arguments.
#
if [ $# != 2 ]; then
    echo "USAGE: DOGEN_BINARY CODEC" >&2
    exit 1;
fi

#
# Handle dogen binary argument.
#
dogen_binary=$1;
if [ ! -f ${dogen_binary} ]; then
    echo "Could not find dogen binary."
    exit 1;
fi

#
# Get script directory.
#
script_dir="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null && pwd )";
model_dir="${script_dir}/../CSharpRefImpl.Models";
dogen_log_dir="${script_dir}/log";

#
# Dogen options.
#
dogen_general_options="--log-enabled --log-level trace";
dogen_general_options="${dogen_general_options} --byproduct-directory ${dogen_log_dir}";

#
# Convert all models
#
frontend="dia"
models="CSharpRefImpl.CSharpModel CSharpRefImpl.DirectorySettings CSharpRefImpl.LamModel CSharpRefImpl.Profiles";
for model in ${models}; do
    echo "Converting ${model} to $2";
    if [ "$2" = "json" ]; then
        dogen_source_option="--source ${script_dir}/dia/${model}.${frontend}";
        dogen_destination_option="--destination ${script_dir}/json/${model}.tmp.json";
        ${dogen_binary} convert ${dogen_general_options} ${dogen_source_option} ${dogen_destination_option}
        jq . ${script_dir}/json/${model}.tmp.json > ${script_dir}/json/${model}.json
        rm ${script_dir}/json/${model}.tmp.json
    elif [ "$2" = "org" ]; then
        dogen_source_option="--source ${script_dir}/dia/${model}.${frontend}";
        dogen_destination_option="--destination ${script_dir}/org/${model}.org";
        ${dogen_binary} convert ${dogen_general_options} ${dogen_source_option} ${dogen_destination_option}
    else
        echo "Unsupported codec: " $2
        exit 1;
    fi
done
