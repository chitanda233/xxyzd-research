package com.bytedance.msdk.adapter.baidu;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.FrameLayout;

/* JADX INFO: loaded from: classes2.dex */
public class VisibleStateFrameLayout extends FrameLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private VisibilityChanged f1815a;

    public interface VisibilityChanged {
        void callback(boolean z);
    }

    public VisibleStateFrameLayout(Context context) {
        super(context);
    }

    public VisibleStateFrameLayout(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
    }

    public VisibleStateFrameLayout(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
    }

    @Override // android.view.View
    public void onVisibilityChanged(View view, int i) {
        super.onVisibilityChanged(view, i);
        VisibilityChanged visibilityChanged = this.f1815a;
        if (visibilityChanged == null || view != this) {
            return;
        }
        visibilityChanged.callback(i == 0);
    }

    public void setVisibilityChanged(VisibilityChanged visibilityChanged) {
        this.f1815a = visibilityChanged;
    }
}
