package com.sigmob.sdk.base.views;

import android.content.Context;
import android.util.AttributeSet;
import android.widget.RelativeLayout;

/* JADX INFO: loaded from: classes3.dex */
public class am extends v {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private al f3294a;
    private f b;
    private boolean c;

    public am(Context context) {
        super(context);
        this.c = false;
        c();
    }

    public am(Context context, AttributeSet attrs) {
        super(context, attrs);
        this.c = false;
        c();
    }

    public am(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        this.c = false;
        c();
    }

    private void c() {
        f fVar = new f(getContext());
        this.b = fVar;
        addView(fVar, new RelativeLayout.LayoutParams(-1, -1));
        this.f3294a = new al(getContext());
        addView(this.f3294a, new RelativeLayout.LayoutParams(-1, -1));
    }

    @Override // com.sigmob.sdk.base.views.v
    public void a() {
        this.c = true;
    }

    public void a(float progress) {
        al alVar = this.f3294a;
        if (alVar == null || !this.c) {
            return;
        }
        alVar.a(progress);
    }

    @Override // com.sigmob.sdk.base.views.v
    public void b() {
        this.c = false;
        al alVar = this.f3294a;
        if (alVar == null) {
            return;
        }
        alVar.a(0.0f);
    }

    @Override // android.view.View
    protected void onSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
    }
}
