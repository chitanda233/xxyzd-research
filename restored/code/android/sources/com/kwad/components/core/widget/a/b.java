package com.kwad.components.core.widget.a;

import android.view.View;
import com.kwad.sdk.api.core.fragment.KsFragment;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends a {
    private final AtomicBoolean awC;
    private KsFragment awH;
    private String awI;

    public b(KsFragment ksFragment, View view, int i) {
        super(view, 70);
        this.awC = new AtomicBoolean(false);
        this.awH = ksFragment;
    }

    @Override // com.kwad.components.core.widget.a.a
    public final boolean ah() {
        KsFragment ksFragment = this.awH;
        if (ksFragment == null) {
            return false;
        }
        if (a(ksFragment)) {
            this.awI = "message fragment";
            return false;
        }
        this.awI = "message view";
        return Ao();
    }

    private static boolean a(KsFragment ksFragment) {
        return (ksFragment.isResumed() && !ksFragment.isAllFragmentIsHidden() && ksFragment.isVisible()) ? false : true;
    }

    @Override // com.kwad.components.core.widget.a.a, com.kwad.sdk.core.j.a
    public final void release() {
        super.release();
        this.awH = null;
    }
}
