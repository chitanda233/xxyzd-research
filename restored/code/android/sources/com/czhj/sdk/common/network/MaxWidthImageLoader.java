package com.czhj.sdk.common.network;

import android.content.Context;
import android.graphics.Point;
import android.view.Display;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.czhj.sdk.common.utils.DeviceUtils;
import com.czhj.volley.RequestQueue;
import com.czhj.volley.toolbox.ImageLoader;

/* JADX INFO: loaded from: classes2.dex */
class MaxWidthImageLoader extends ImageLoader {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final int f2261a;

    MaxWidthImageLoader(RequestQueue requestQueue, Context context, ImageLoader.ImageCache imageCache) {
        int iMin;
        super(requestQueue, imageCache);
        Display display = DeviceUtils.getDisplay(context);
        if (display == null) {
            iMin = MediaPlayer.MEDIA_PLAYER_OPTION_LAST_VIDEO_RENDER_TIME;
        } else {
            Point point = new Point();
            display.getSize(point);
            iMin = Math.min(point.x, point.y);
        }
        this.f2261a = iMin;
    }

    @Override // com.czhj.volley.toolbox.ImageLoader
    public ImageLoader.ImageContainer get(String str, ImageLoader.ImageListener imageListener) {
        return super.get(str, imageListener, this.f2261a, 0);
    }
}
