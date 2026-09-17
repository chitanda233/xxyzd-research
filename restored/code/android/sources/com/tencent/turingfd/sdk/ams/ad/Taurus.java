package com.tencent.turingfd.sdk.ams.ad;

import java.io.UnsupportedEncodingException;
import java.security.KeyFactory;
import java.security.SecureRandom;
import java.security.spec.X509EncodedKeySpec;
import javax.crypto.Cipher;

/* JADX INFO: loaded from: classes4.dex */
public final class Taurus {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Plum f3899a = new Plum();
    public Pistachio b = null;

    public final void a() {
        byte[] bArrDoFinal;
        Tangor tangor = Teazle.f3900a;
        SecureRandom secureRandom = new SecureRandom();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 16; i++) {
            sb.append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".charAt(secureRandom.nextInt(62)));
        }
        String string = sb.toString();
        Cnative cnative = new Cnative();
        cnative.f3949a = 1;
        Plum plum = this.f3899a;
        cnative.d = 0;
        cnative.c = "EP_TuringMM";
        try {
            if (plum.f3880a == null) {
                try {
                    plum.f3880a = KeyFactory.getInstance(com.alipay.sdk.m.p.d.f334a).generatePublic(new X509EncodedKeySpec(Cfinal.a()));
                } catch (Exception unused) {
                }
            }
            Plum plum2 = this.f3899a;
            byte[] bytes = string == null ? null : string.getBytes("utf-8");
            try {
                Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
                cipher.init(1, plum2.f3880a);
                bArrDoFinal = cipher.doFinal(bytes);
            } catch (Exception unused2) {
                bArrDoFinal = null;
            }
            cnative.b = bArrDoFinal;
            Pistachio pistachio = new Pistachio(Sagittarius.a(cnative), string, null, 0);
            synchronized (this) {
                this.b = pistachio;
            }
        } catch (UnsupportedEncodingException unused3) {
        }
    }

    public final synchronized void b() {
        a();
    }
}
