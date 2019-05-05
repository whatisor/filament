//------------------------------------------------------------------------------
// Uniforms access
//------------------------------------------------------------------------------

/** @public-api */
mat4 getViewFromWorldMatrix() {
    return viewFromWorldMatrix;
}

/** @public-api */
mat4 getWorldFromViewMatrix() {
    return worldFromViewMatrix;
}

/** @public-api */
mat4 getClipFromViewMatrix() {
    return clipFromViewMatrix;
}

/** @public-api */
mat4 getViewFromClipMatrix() {
    return viewFromClipMatrix;
}

/** @public-api */
mat4 getClipFromWorldMatrix() {
    return clipFromWorldMatrix;
}

/** @public-api */
mat4 getWorldFromClipMatrix() {
    return worldFromClipMatrix;
}

/** @public-api */
vec4 getResolution() {
    return resolution;
}

/** @public-api */
vec3 getWorldCameraPosition() {
    return cameraPosition;
}

/** @public-api */
float getTime() {
    return time;
}

/** @public-api */
HIGHP vec4 getUserTime() {
    return userTime;
}

/** @public-api **/
HIGHP float getUserTimeMod(float m) {
    return mod(mod(userTime.x, m) + mod(userTime.y, m), m);
}

/** @public-api */
float getExposure() {
    return exposure;
}

/** @public-api */
float getEV100() {
    return ev100;
}
