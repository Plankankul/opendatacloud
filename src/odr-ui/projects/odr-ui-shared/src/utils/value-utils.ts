// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.


export function isEmptyValue(value: any) {
  if(value === undefined || value === null) {
    return true;
  } else if(typeof value === "string") {
    return /^\s*$/.test(value);
  } else {
    return false;
  }
}
