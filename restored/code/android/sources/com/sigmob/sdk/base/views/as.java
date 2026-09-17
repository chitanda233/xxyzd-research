package com.sigmob.sdk.base.views;

import android.content.Context;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.utils.Dips;

/* JADX INFO: loaded from: classes3.dex */
public class as extends ImageView {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private y f3305a;
    private final int b;

    public as(Context context) {
        super(context);
        y yVar = new y(context);
        this.f3305a = yVar;
        setImageDrawable(yVar);
        this.b = Dips.dipsToIntPixels(2.0f, context);
    }

    public void a(int progress) {
        this.f3305a.a(progress);
    }

    public void a(int duration, int skipOffset) {
        this.f3305a.a(duration, skipOffset);
        setVisibility(0);
    }

    @Deprecated
    y getImageViewDrawable() {
        return this.f3305a;
    }

    public void setAnchorId(int anchorId) {
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, this.b);
        layoutParams.addRule(12, anchorId);
        setLayoutParams(layoutParams);
    }

    @Deprecated
    void setImageViewDrawable(y drawable) {
        this.f3305a = drawable;
    }
}
