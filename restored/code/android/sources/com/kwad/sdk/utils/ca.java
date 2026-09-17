package com.kwad.sdk.utils;

import android.graphics.Point;
import android.graphics.Rect;
import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public final class ca {
    private View bry;
    public Point brx = new Point();
    public Rect brv = new Rect();
    public Rect brw = new Rect();

    public ca(View view) {
        this.bry = view;
    }

    public final boolean Xq() {
        boolean globalVisibleRect = this.bry.getGlobalVisibleRect(this.brv, this.brx);
        if (this.brx.x == 0 && this.brx.y == 0 && this.brv.height() == this.bry.getHeight() && this.brw.height() != 0 && Math.abs(this.brv.top - this.brw.top) > this.bry.getHeight() / 2) {
            this.brv.set(this.brw);
        }
        this.brw.set(this.brv);
        return globalVisibleRect;
    }
}
