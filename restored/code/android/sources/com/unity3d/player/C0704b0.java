package com.unity3d.player;

import android.content.Context;
import android.view.KeyEvent;
import android.widget.EditText;

/* JADX INFO: renamed from: com.unity3d.player.b0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0704b0 extends EditText {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ S f4030a;
    final /* synthetic */ C0706c0 b;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    C0704b0(C0706c0 c0706c0, Context context, S s) {
        super(context);
        this.b = c0706c0;
        this.f4030a = s;
    }

    @Override // android.widget.TextView, android.view.View
    public final boolean onKeyPreIme(int i, KeyEvent keyEvent) {
        if (i == 4) {
            if (keyEvent.getAction() == 1) {
                this.b.h.onBackPressed();
            }
            return true;
        }
        if (i == 84) {
            return true;
        }
        if (i == 66 && keyEvent.getAction() == 0 && (getInputType() & 131072) == 0) {
            S s = this.f4030a;
            s.a(s.b(), false);
            return true;
        }
        if (i != 111 || keyEvent.getAction() != 0) {
            return super.onKeyPreIme(i, keyEvent);
        }
        S s2 = this.f4030a;
        s2.a(s2.b(), true);
        return true;
    }

    @Override // android.widget.TextView, android.view.View
    public final void onWindowFocusChanged(boolean z) {
        super.onWindowFocusChanged(z);
        if (z) {
            requestFocus();
            this.f4030a.f();
        }
    }
}
