package com.tencent.turingfd.sdk.ams.ad;

import android.util.Base64;
import java.io.ByteArrayInputStream;
import java.security.cert.Certificate;
import java.security.cert.CertificateFactory;
import java.security.cert.X509Certificate;
import java.util.ArrayList;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class Strawberry {
    public static final String e = Cinstanceof.a(Cinstanceof.L0);
    public static final String f = Cinstanceof.a(Cinstanceof.M0);
    public static final String g = Cinstanceof.a(Cinstanceof.N0);
    public static final String h = Cinstanceof.a(Cinstanceof.O0);
    public static final String i = Cinstanceof.a(Cinstanceof.P0);

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f3894a;
    public int b;
    public String c;
    public final ArrayList d;

    public Strawberry(String str) {
        this.f3894a = -1L;
        this.b = -1;
        this.c = "";
        this.d = null;
        try {
            JSONObject jSONObject = new JSONObject(str);
            String str2 = i;
            if (!jSONObject.has(str2)) {
                this.f3894a = jSONObject.optLong(f);
                this.b = jSONObject.optInt(h);
                this.c = jSONObject.optString(g);
                jSONObject.optString(e);
                return;
            }
            JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray(str2);
            jSONArrayOptJSONArray.length();
            this.d = new ArrayList();
            for (int i2 = 0; i2 < jSONArrayOptJSONArray.length(); i2++) {
                this.d.add(jSONArrayOptJSONArray.getString(i2));
            }
            try {
                Creturn.a((X509Certificate) CertificateFactory.getInstance("X.509").generateCertificate(new ByteArrayInputStream(((String) this.d.get(0)).getBytes())), this);
            } catch (Exception unused) {
            }
            jSONObject.put(g, this.c);
            jSONObject.put(h, this.b);
            jSONObject.put(f, this.f3894a);
            jSONObject.toString();
        } catch (Exception unused2) {
        }
    }

    public Strawberry(Certificate[] certificateArr) {
        this.f3894a = -1L;
        this.b = -1;
        this.c = "";
        this.d = null;
        if (certificateArr != null) {
            try {
                ArrayList arrayList = new ArrayList();
                JSONArray jSONArray = new JSONArray();
                for (int i2 = 0; i2 < certificateArr.length; i2++) {
                    Certificate certificate = certificateArr[i2];
                    Base64.encodeToString(certificate.getEncoded(), 2);
                    String strA = Creturn.a(certificate);
                    if (i2 == 0) {
                        try {
                            Creturn.a((X509Certificate) certificate, this);
                        } catch (Exception unused) {
                        }
                    }
                    jSONArray.put(strA);
                    arrayList.add(strA);
                }
                this.d = arrayList;
                JSONObject jSONObject = new JSONObject();
                jSONObject.put(i, jSONArray);
                jSONObject.put(g, this.c);
                jSONObject.put(h, this.b);
                jSONObject.put(f, this.f3894a);
                jSONObject.toString();
            } catch (Exception unused2) {
            }
        }
    }
}
