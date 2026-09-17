package com.sigmob.sdk.videoplayer;

import android.graphics.SurfaceTexture;

/* JADX INFO: loaded from: classes4.dex */
public interface h {
    void a(int what, int extra);

    void b(int what, int extra);

    void c(int width, int height);

    g getVideoPlayerDataSource();

    void o();

    void p();

    void q();

    void setBufferProgress(int percent);

    void setSurfaceTexture(SurfaceTexture saved_surface);
}
