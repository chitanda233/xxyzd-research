package com.sigmob.sdk.videoAd;

import android.content.Context;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.utils.Dips;
import com.sigmob.sdk.base.views.y;

/* JADX INFO: loaded from: classes4.dex */
public class i extends ImageView {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private y f3637a;
    private final int b;

    public i(Context context) {
        super(context);
        y yVar = new y(context);
        this.f3637a = yVar;
        setImageDrawable(yVar);
        this.b = Dips.dipsToIntPixels(2.0f, context);
    }

    public void a() {
        this.f3637a.a();
        this.f3637a.a(0);
    }

    public void a(int progress) {
        this.f3637a.a(progress);
    }

    public void a(int duration, int skipOffset) {
        this.f3637a.a(duration, skipOffset);
        setVisibility(0);
    }

    @Deprecated
    y getImageViewDrawable() {
        return this.f3637a;
    }

    public void setAnchorId(int anchorId) {
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, this.b);
        layoutParams.addRule(8, anchorId);
        setLayoutParams(layoutParams);
    }

    @Deprecated
    void setImageViewDrawable(y drawable) {
        this.f3637a = drawable;
    }
}
