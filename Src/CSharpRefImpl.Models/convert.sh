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
frontend="org"
models="CSharpRefImpl.CSharpModel CSharpRefImpl.DirectorySettings CSharpRefImpl.LamModel CSharpRefImpl.Profiles";
for model in ${models}; do
    echo "Converting ${model} to PlantUML";
    dogen_source_option="--source ${script_dir}/${frontend}/${model}.${frontend}";
    dogen_destination_option="--destination ${script_dir}/org/${model}.plantuml";
    ${dogen_binary} convert ${dogen_general_options} ${dogen_source_option} ${dogen_destination_option}
done
