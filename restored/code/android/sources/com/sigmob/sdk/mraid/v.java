package com.sigmob.sdk.mraid;

import android.content.Context;
import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public class v extends com.sigmob.sdk.base.views.g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final int f3520a = 1;
    private a b;
    private boolean c;

    public interface a {
        void onVisibilityChanged(boolean isVisible);
    }

    public v(Context context) {
        super(context);
    }

    private void setMraidViewable(final boolean viewable) {
        if (this.c == viewable) {
            return;
        }
        this.c = viewable;
        a aVar = this.b;
        if (aVar == null) {
            return;
        }
        aVar.onVisibilityChanged(viewable);
    }

    @Override // com.sigmob.sdk.base.views.g, android.webkit.WebView
    public void destroy() {
        super.destroy();
        this.b = null;
    }

    public boolean j() {
        return this.c;
    }

    @Override // android.webkit.WebView, android.view.View
    protected void onVisibilityChanged(View changedView, int visibility) {
        super.onVisibilityChanged(changedView, visibility);
        if (visibility == 0) {
            return;
        }
        setMraidViewable(false);
    }

    public void setVisibilityChangedListener(a listener) {
        this.b = listener;
    }
}
