package com.kwad.components.core.widget.a;

import android.os.Message;
import android.view.View;
import com.bytedance.sdk.openadsdk.TTAdConstant;
import com.kwad.sdk.utils.ar;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.utils.cc;
import java.util.HashSet;
import java.util.Set;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a implements com.kwad.sdk.core.j.a, cc.a {
    private Set<com.kwad.sdk.core.j.c> awD;
    private final int awE;
    private final View mRootView;
    private final AtomicBoolean awC = new AtomicBoolean(false);
    protected final cc ca = new cc(this);

    public abstract boolean ah();

    public a(View view, int i) {
        this.mRootView = view;
        this.awE = i;
    }

    public void a(Message message) {
        if (message.what == 666) {
            Al();
            this.ca.sendEmptyMessageDelayed(TTAdConstant.STYLE_SIZE_RADIO_2_3, 500L);
        }
    }

    public final void Al() {
        if (ah()) {
            ks();
        } else {
            Ap();
        }
    }

    public final void Am() {
        this.ca.removeMessages(TTAdConstant.STYLE_SIZE_RADIO_2_3);
        this.ca.sendEmptyMessage(TTAdConstant.STYLE_SIZE_RADIO_2_3);
    }

    public final void An() {
        Al();
        this.ca.removeCallbacksAndMessages(null);
    }

    public final boolean Ao() {
        return cb.a(this.mRootView, this.awE, false);
    }

    private void ks() {
        if (this.awC.getAndSet(true)) {
            return;
        }
        br(true);
    }

    private void Ap() {
        if (this.awC.getAndSet(false)) {
            br(false);
        }
    }

    private void br(boolean z) {
        Set<com.kwad.sdk.core.j.c> set = this.awD;
        if (set == null) {
            return;
        }
        for (com.kwad.sdk.core.j.c cVar : set) {
            if (cVar != null) {
                if (z) {
                    cVar.bv();
                } else {
                    cVar.bw();
                }
            }
        }
    }

    @Override // com.kwad.sdk.core.j.a
    public final boolean Aq() {
        return this.awC.get();
    }

    @Override // com.kwad.sdk.core.j.a
    public final void a(final com.kwad.sdk.core.j.c cVar) {
        ar.checkUiThread();
        if (cVar == null) {
            return;
        }
        by.postOnUiThread(new bi() { // from class: com.kwad.components.core.widget.a.a.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (a.this.ah()) {
                    cVar.bv();
                } else {
                    cVar.bw();
                }
            }
        });
        if (this.awD == null) {
            this.awD = new HashSet();
        }
        this.awD.add(cVar);
    }

    @Override // com.kwad.sdk.core.j.a
    public final void b(com.kwad.sdk.core.j.c cVar) {
        Set<com.kwad.sdk.core.j.c> set;
        ar.checkUiThread();
        if (cVar == null || (set = this.awD) == null) {
            return;
        }
        set.remove(cVar);
    }

    @Override // com.kwad.sdk.core.j.a
    public void release() {
        An();
        Set<com.kwad.sdk.core.j.c> set = this.awD;
        if (set != null) {
            set.clear();
        }
    }
}
