package com.kwad.components.core.page.recycle;

import android.view.View;
import androidx.recyclerview.widget.OrientationHelper;
import androidx.recyclerview.widget.RecyclerView;
import com.kwad.sdk.utils.az;

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    final RecyclerView afv;
    final RecyclerView.LayoutManager afw;

    private f(RecyclerView recyclerView) {
        this.afv = recyclerView;
        this.afw = recyclerView.getLayoutManager();
    }

    public static f b(RecyclerView recyclerView) {
        az.checkNotNull(recyclerView);
        return new f(recyclerView);
    }

    public final int findFirstVisibleItemPosition() {
        View viewA = a(0, this.afw.getChildCount(), false, true);
        if (viewA == null) {
            return -1;
        }
        return this.afv.getChildAdapterPosition(viewA);
    }

    public final int findLastVisibleItemPosition() {
        View viewA = a(this.afw.getChildCount() - 1, -1, false, true);
        if (viewA == null) {
            return -1;
        }
        return this.afv.getChildAdapterPosition(viewA);
    }

    private View a(int i, int i2, boolean z, boolean z2) {
        OrientationHelper orientationHelperCreateHorizontalHelper;
        if (this.afw.canScrollVertically()) {
            orientationHelperCreateHorizontalHelper = OrientationHelper.createVerticalHelper(this.afw);
        } else {
            orientationHelperCreateHorizontalHelper = OrientationHelper.createHorizontalHelper(this.afw);
        }
        int startAfterPadding = orientationHelperCreateHorizontalHelper.getStartAfterPadding();
        int endAfterPadding = orientationHelperCreateHorizontalHelper.getEndAfterPadding();
        int i3 = i2 > i ? 1 : -1;
        while (i != i2) {
            View childAt = this.afw.getChildAt(i);
            int decoratedStart = orientationHelperCreateHorizontalHelper.getDecoratedStart(childAt);
            int decoratedEnd = orientationHelperCreateHorizontalHelper.getDecoratedEnd(childAt);
            if (decoratedStart < endAfterPadding && decoratedEnd > startAfterPadding) {
                return childAt;
            }
            i += i3;
        }
        return null;
    }
}
