package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.media.MediaPlayer;
import android.view.KeyEvent;
import android.view.View;
import android.widget.VideoView;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.u, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public class C0615u extends VideoView {
    public C0615u(Context context) {
        super(context);
    }

    @Override // android.widget.VideoView, android.view.View, android.view.KeyEvent.Callback
    public boolean onKeyDown(int i, KeyEvent keyEvent) {
        return super.onKeyDown(i, keyEvent);
    }

    @Override // android.widget.VideoView, android.view.SurfaceView, android.view.View
    protected void onMeasure(int i, int i2) {
        super.onMeasure(i, i2);
        setMeasuredDimension(View.getDefaultSize(0, i), View.getDefaultSize(0, i2));
    }

    @Override // android.widget.VideoView
    public void setOnPreparedListener(MediaPlayer.OnPreparedListener onPreparedListener) {
        super.setOnPreparedListener(onPreparedListener);
    }
}
