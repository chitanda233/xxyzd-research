package com.kwad.components.core.page.recycle;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import androidx.recyclerview.widget.RecyclerView;

/* JADX INFO: loaded from: classes3.dex */
public class g extends RecyclerView {
    private boolean afx;

    public g(Context context) {
        super(context);
    }

    public g(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
    }

    public g(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
    }

    public void setIngoreTmpDetachedFlag(boolean z) {
        this.afx = z;
    }

    protected void removeDetachedView(View view, boolean z) {
        if (!this.afx) {
            super.removeDetachedView(view, z);
        } else {
            super.removeDetachedView(view, z);
        }
    }
}
