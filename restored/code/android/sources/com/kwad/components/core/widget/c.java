package com.kwad.components.core.widget;

import android.content.Context;
import android.os.Message;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.utils.cc;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends View implements cc.a {
    private a avG;
    private boolean avH;
    private final int avI;
    private boolean avm;
    private boolean avn;
    private View bZ;
    private final cc ca;
    private final AtomicBoolean cb;

    public interface a {
        void fx();
    }

    public c(Context context, View view) {
        super(context);
        this.ca = new cc(this);
        this.cb = new AtomicBoolean(true);
        this.avI = (int) (com.kwad.sdk.core.config.e.Ko() * 100.0f);
        this.bZ = view;
        setLayoutParams(new ViewGroup.LayoutParams(0, 0));
    }

    public final void setViewCallback(a aVar) {
        this.avG = aVar;
    }

    @Override // android.view.View
    protected final void onAttachedToWindow() {
        super.onAttachedToWindow();
        com.kwad.sdk.core.d.c.d("EmptyView", "onAttachedToWindow:" + this);
        zX();
        this.avm = false;
        Ab();
    }

    @Override // android.view.View
    protected final void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        com.kwad.sdk.core.d.c.d("EmptyView", "onDetachedFromWindow" + this);
        zW();
        this.avm = true;
        Ac();
    }

    @Override // android.view.View
    public final void onFinishTemporaryDetach() {
        super.onFinishTemporaryDetach();
        com.kwad.sdk.core.d.c.d("EmptyView", "onFinishTemporaryDetach:" + this.bZ.getParent());
        Ab();
    }

    @Override // android.view.View
    public final void onStartTemporaryDetach() {
        super.onStartTemporaryDetach();
        com.kwad.sdk.core.d.c.d("EmptyView", "onStartTemporaryDetach:" + this.bZ.getParent());
        Ac();
    }

    @Override // android.view.View
    public final void onWindowFocusChanged(boolean z) {
        super.onWindowFocusChanged(z);
        com.kwad.sdk.core.d.c.d("EmptyView", "onWindowFocusChanged hasWindowFocus:" + z);
    }

    @Override // android.view.View
    protected final void onWindowVisibilityChanged(int i) {
        super.onWindowVisibilityChanged(i);
        com.kwad.sdk.core.d.c.d("EmptyView", "onWindowVisibilityChanged visibility:" + i);
    }

    private void Ab() {
        this.cb.getAndSet(false);
    }

    private void Ac() {
        this.cb.getAndSet(true);
    }

    private void zW() {
        if (this.avn) {
            this.ca.removeCallbacksAndMessages(null);
            this.avn = false;
        }
    }

    private void zX() {
        if (!this.avH || this.avn) {
            return;
        }
        this.avn = true;
        this.ca.sendEmptyMessage(1);
    }

    public final void setNeedCheckingShow(boolean z) {
        this.avH = z;
        if (!z && this.avn) {
            zW();
        } else {
            if (!z || this.avn) {
                return;
            }
            zX();
        }
    }

    @Override // com.kwad.sdk.utils.cc.a
    public final void a(Message message) {
        a aVar;
        int i = message.what;
        if (i != 1) {
            if (i != 2) {
                return;
            }
            if (!cb.a(this.bZ, this.avI, false)) {
                if (this.avm) {
                    return;
                }
                setNeedCheckingShow(true);
                return;
            } else {
                if (message.arg1 == 1000 && (aVar = this.avG) != null) {
                    aVar.fx();
                }
                this.ca.sendEmptyMessageDelayed(2, 500L);
                return;
            }
        }
        com.kwad.sdk.core.d.c.d("EmptyView", "handleMsg MSG_CHECKING");
        if (this.avn) {
            if (cb.a(this.bZ, this.avI, false)) {
                zW();
                Message messageObtainMessage = this.ca.obtainMessage();
                messageObtainMessage.what = 2;
                messageObtainMessage.arg1 = 1000;
                this.ca.sendMessageDelayed(messageObtainMessage, 1000L);
                return;
            }
            this.ca.sendEmptyMessageDelayed(1, 500L);
        }
    }
}
