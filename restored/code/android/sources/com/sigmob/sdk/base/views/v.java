package com.sigmob.sdk.base.views;

import android.content.Context;
import android.util.AttributeSet;
import android.widget.RelativeLayout;

/* JADX INFO: loaded from: classes3.dex */
public abstract class v extends RelativeLayout {
    public v(Context context) {
        super(context);
    }

    public v(Context context, AttributeSet attrs) {
        super(context, attrs);
    }

    public v(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
    }

    public abstract void a();

    public abstract void b();
}
