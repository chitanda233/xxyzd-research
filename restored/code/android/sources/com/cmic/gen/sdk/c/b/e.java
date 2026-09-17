package com.cmic.gen.sdk.c.b;

import android.util.Base64;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: GetPrePhoneScripParameter.java */
/* JADX INFO: loaded from: classes2.dex */
public class e extends h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private a f2080a;
    private byte[] b;
    private String c;
    private byte[] d;
    private String e;
    private boolean f = false;

    @Override // com.cmic.gen.sdk.c.b.h
    protected String a_(String str) {
        return null;
    }

    public void a(boolean z) {
        this.f = z;
    }

    public void b(String str) {
        this.e = str;
    }

    public void a(byte[] bArr) {
        this.b = bArr;
    }

    public void c(String str) {
        this.c = str;
    }

    public void b(byte[] bArr) {
        this.d = bArr;
    }

    public void a(a aVar) {
        this.f2080a = aVar;
    }

    public a c() {
        return this.f2080a;
    }

    @Override // com.cmic.gen.sdk.c.b.h
    public String a() {
        return this.f2080a.a();
    }

    @Override // com.cmic.gen.sdk.c.b.h
    public JSONObject b() {
        JSONObject jSONObject = new JSONObject();
        if (this.f) {
            try {
                jSONObject.put("encrypted", this.c);
                jSONObject.put("encryptedIV", Base64.encodeToString(this.d, 0));
                jSONObject.put("reqdata", com.cmic.gen.sdk.f.a.a(this.b, this.f2080a.toString(), this.d));
                jSONObject.put("securityreinforce", this.e);
            } catch (JSONException e) {
                e.printStackTrace();
            }
        }
        return jSONObject;
    }
}
