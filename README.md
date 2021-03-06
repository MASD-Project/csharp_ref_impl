[![Licence](https://img.shields.io/badge/license-GPL_3-green.svg?dummy)](https://raw.githubusercontent.com/MASD-Project/csharp_ref_impl/master/LICENCE)
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2FMASD-Project%2Fcsharp_ref_impl.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2FMASD-Project%2Fcsharp_ref_impl?ref=badge_shield)
[![Status](https://img.shields.io/badge/status-active-brightgreen.svg?style=flat)](https://github.com/MASD-Project/csharp_ref_impl/pulse/monthly)
[![Gitter](https://img.shields.io/gitter/room/nwjs/nw.js.svg)](https://gitter.im/MASD-Project/Lobby)
[![Code Quality: C#](https://img.shields.io/lgtm/grade/csharp/g/MASD-Project/csharp_ref_impl.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/MASD-Project/csharp_ref_impl/context:csharp)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/5d998ea32f27479392c2c7b2309bd84a)](https://www.codacy.com/app/marco-craveiro/csharp_ref_impl?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=MASD-Project/csharp_ref_impl&amp;utm_campaign=Badge_Grade)
[![Build Status](https://travis-ci.org/MASD-Project/csharp_ref_impl.svg?branch=master)](https://travis-ci.org/MASD-Project/csharp_ref_impl)
[![Build Status](https://img.shields.io/appveyor/ci/mcraveiro/csharp-ref-impl.svg?label=windows)](https://ci.appveyor.com/project/mcraveiro/csharp-ref-impl)
[![codecov](https://codecov.io/gh/MASD-Project/csharp_ref_impl/branch/master/graph/badge.svg)](https://codecov.io/gh/MASD-Project/csharp_ref_impl)

# MASD C# Reference Implementation

This project contains the MASD C# Reference Implementation, generated
using the [latest version of
Dogen](https://github.com/MASD-Project/dogen/releases). The objective
of a MASD reference implementation is to exercise all of the available
functionality within Dogen and to unit test it to ensure it works as
specified. The models used to generate the reference implementation
are available under
[Src/Models](https://github.com/MASD-Project/csharp_ref_impl/tree/master/Src/Models). As
the objective of the reference implementation is to exercise Dogen as
much as possible, the models are available in both Dia and JSON
formats.

Please note that C# support in MASD still lags behind C++, so some
functionality is not yet available.

# Test Models

The Reference Implementation is composed of a number of test
models. These can be summarised as follows:

| Name              | Description                                        |
|-------------------|----------------------------------------------------|
| CSharpModel       | Model testing core C# language features.           |
| DirectorySettings | Exercises all file and directory settings in MASD. |
| LamModel          | Language Agnostic Model targeting C#.              |

# Reporting Problems

If you have found any issues with the generated C# code, we ask you to
please report it in order to make the code generator better. Examples
of issues with the generated code:

- it may be using non-idiomatic C#, or following old idioms;
- it may work, but you know of a better way of doing it;
- it is just wrong, and we've missed it.

Issues can be submitted using [github
Issues](https://github.com/MASD-Project/csharp_ref_impl/issues).
