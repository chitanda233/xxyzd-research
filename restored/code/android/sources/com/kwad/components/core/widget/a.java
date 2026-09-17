package com.kwad.components.core.widget;

import android.content.Context;
import android.os.Message;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.utils.cc;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends KSFrameLayout implements cc.a {
    private InterfaceC0474a avl;
    private boolean avm;
    private boolean avn;
    private int avo;
    private boolean avp;
    private long avq;
    private boolean avr;
    private final float avs;
    private final int avt;
    private final View bZ;
    private final cc ca;

    /* JADX INFO: renamed from: com.kwad.components.core.widget.a$a, reason: collision with other inner class name */
    public interface InterfaceC0474a {
        void aA();

        void ae();

        void af();

        void b(View view);

        void onWindowFocusChanged(boolean z);
    }

    public a(Context context, View view) {
        super(context, view);
        this.ca = new cc(this);
        this.avo = 5;
        this.bZ = view;
        setLayoutParams(new ViewGroup.LayoutParams(1, 1));
        float fKo = com.kwad.sdk.core.config.e.Ko();
        this.avs = fKo;
        setVisiblePercent(fKo);
        float fKq = com.kwad.sdk.core.config.e.Kq();
        this.avt = (int) ((fKq < 0.0f ? 1.0f : fKq) * 1000.0f);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout, com.kwad.sdk.widget.k
    public final void H(View view) {
        InterfaceC0474a interfaceC0474a;
        InterfaceC0474a interfaceC0474a2;
        super.H(view);
        if (this.avt == 0 && (interfaceC0474a2 = this.avl) != null) {
            interfaceC0474a2.b(view);
            return;
        }
        if (!this.avp) {
            this.avp = true;
            this.avq = System.currentTimeMillis();
            zW();
            zV();
            return;
        }
        if (System.currentTimeMillis() - this.avq <= this.avt || (interfaceC0474a = this.avl) == null) {
            return;
        }
        interfaceC0474a.b(view);
        zW();
    }

    private void zV() {
        InterfaceC0474a interfaceC0474a;
        if (this.avt == 0 && (interfaceC0474a = this.avl) != null) {
            interfaceC0474a.b(this.bZ);
            return;
        }
        Message messageObtainMessage = this.ca.obtainMessage();
        messageObtainMessage.what = 2;
        this.ca.sendMessageDelayed(messageObtainMessage, this.avt);
    }

    public final void setViewCallback(InterfaceC0474a interfaceC0474a) {
        this.avl = interfaceC0474a;
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout, android.view.View
    public final void onWindowFocusChanged(boolean z) {
        super.onWindowFocusChanged(z);
        com.kwad.sdk.core.d.c.d("AdExposureView", "onWindowFocusChanged hasWindowFocus:" + z);
        InterfaceC0474a interfaceC0474a = this.avl;
        if (interfaceC0474a != null) {
            interfaceC0474a.onWindowFocusChanged(z);
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        super.ae();
        this.avo = 5;
        this.avm = false;
        this.avp = false;
        zX();
        com.kwad.sdk.core.d.c.d("ceshi", "onViewAttached");
        InterfaceC0474a interfaceC0474a = this.avl;
        if (interfaceC0474a != null) {
            interfaceC0474a.ae();
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
        zW();
        this.avo = 0;
        this.avq = 0L;
        this.avm = true;
        InterfaceC0474a interfaceC0474a = this.avl;
        if (interfaceC0474a != null) {
            interfaceC0474a.af();
        }
    }

    private void zW() {
        this.ca.removeCallbacksAndMessages(null);
        this.avn = false;
    }

    private void zX() {
        if (this.avn) {
            return;
        }
        this.avn = true;
        this.ca.sendEmptyMessage(1);
    }

    public final void zY() {
        zX();
    }

    @Override // com.kwad.sdk.utils.cc.a
    public final void a(Message message) {
        if (this.avm) {
            return;
        }
        int i = message.what;
        if (i != 1) {
            if (i != 2) {
                return;
            }
            if (cb.a(this.bZ, (int) (this.avs * 100.0f), false)) {
                InterfaceC0474a interfaceC0474a = this.avl;
                if (interfaceC0474a != null) {
                    interfaceC0474a.b(this.bZ);
                    return;
                }
                return;
            }
            this.avo = 5;
            this.ca.sendEmptyMessage(1);
            return;
        }
        if (cb.a(this.bZ, (int) (this.avs * 100.0f), false)) {
            zW();
            if (this.avp) {
                InterfaceC0474a interfaceC0474a2 = this.avl;
                if (interfaceC0474a2 != null) {
                    interfaceC0474a2.b(this.bZ);
                }
            } else {
                this.avp = true;
                this.avq = System.currentTimeMillis();
                zV();
            }
            this.avr = false;
            cc ccVar = this.ca;
            int i2 = this.avo;
            this.avo = i2 - 1;
            ccVar.sendEmptyMessageDelayed(1, i2 <= 0 ? 500L : 100L);
            return;
        }
        InterfaceC0474a interfaceC0474a3 = this.avl;
        if (interfaceC0474a3 != null && !this.avr) {
            interfaceC0474a3.aA();
        }
        this.avr = true;
        cc ccVar2 = this.ca;
        int i3 = this.avo;
        this.avo = i3 - 1;
        ccVar2.sendEmptyMessageDelayed(1, i3 <= 0 ? 500L : 100L);
    }
}
