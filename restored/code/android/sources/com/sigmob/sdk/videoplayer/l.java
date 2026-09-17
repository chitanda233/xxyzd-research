package com.sigmob.sdk.videoplayer;

import android.content.Context;
import android.util.AttributeSet;
import android.view.TextureView;

/* JADX INFO: loaded from: classes4.dex */
public class l extends TextureView {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected static final String f3698a = "ResizeTextureView";
    public int b;
    public int c;

    public l(Context context) {
        super(context);
        this.b = 0;
        this.c = 0;
    }

    public l(Context context, AttributeSet attrs) {
        super(context, attrs);
        this.b = 0;
        this.c = 0;
    }

    public void a(int currentVideoWidth, int currentVideoHeight) {
        if (this.b == currentVideoWidth && this.c == currentVideoHeight) {
            return;
        }
        this.b = currentVideoWidth;
        this.c = currentVideoHeight;
        requestLayout();
    }

    /* JADX WARN: Code duplicated, block: B:70:0x013b  */
    /* JADX WARN: Code restructure failed: missing block: B:40:0x00e8, code lost:
    
        if (r2 > r12) goto L41;
     */
    /* JADX WARN: Code restructure failed: missing block: B:41:0x00ea, code lost:
    
        r2 = (r12 * r4) / r3;
     */
    /* JADX WARN: Code restructure failed: missing block: B:49:0x00fd, code lost:
    
        if (r2 > r12) goto L41;
     */
    @Override // android.view.View
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    protected void onMeasure(int r18, int r19) {
        /*
            Method dump skipped, instruction units count: 321
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: com.sigmob.sdk.videoplayer.l.onMeasure(int, int):void");
    }

    @Override // android.view.View
    public void setRotation(float rotation) {
        if (rotation != getRotation()) {
            super.setRotation(rotation);
            requestLayout();
        }
    }
}
