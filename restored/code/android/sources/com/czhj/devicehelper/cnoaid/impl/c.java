package com.czhj.devicehelper.cnoaid.impl;

import android.app.KeyguardManager;
import android.content.Context;
import java.util.Objects;

/* JADX INFO: loaded from: classes2.dex */
public class c implements com.czhj.devicehelper.cnoaid.d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2184a;
    private final KeyguardManager b;

    public c(Context context) {
        this.f2184a = context;
        this.b = (KeyguardManager) context.getSystemService("keyguard");
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public void a(com.czhj.devicehelper.cnoaid.c cVar) {
        if (this.f2184a == null || cVar == null) {
            return;
        }
        KeyguardManager keyguardManager = this.b;
        if (keyguardManager == null) {
            cVar.a(new com.czhj.devicehelper.cnoaid.f("KeyguardManager not found"));
            return;
        }
        try {
            Object objInvoke = keyguardManager.getClass().getDeclaredMethod("obtainOaid", new Class[0]).invoke(this.b, new Object[0]);
            if (objInvoke == null) {
                throw new com.czhj.devicehelper.cnoaid.f("OAID obtain failed");
            }
            String string = objInvoke.toString();
            com.czhj.devicehelper.cnoaid.g.a("OAID obtain success: " + string);
            cVar.a(string);
        } catch (Exception e) {
            com.czhj.devicehelper.cnoaid.g.a(e);
        }
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public boolean a() {
        KeyguardManager keyguardManager;
        if (this.f2184a == null || (keyguardManager = this.b) == null) {
            return false;
        }
        try {
            return ((Boolean) Objects.requireNonNull(keyguardManager.getClass().getDeclaredMethod("isSupported", new Class[0]).invoke(this.b, new Object[0]))).booleanValue();
        } catch (Exception e) {
            com.czhj.devicehelper.cnoaid.g.a(e);
            return false;
        }
    }
}
