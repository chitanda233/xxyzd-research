package com.kwad.sdk.api.loader;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class l {
    public static int aIo;

    public static void a(com.kwad.sdk.api.loader.a.C0495a c0495a) {
        aIo++;
        a(1, c0495a, 0L, 0, "");
    }

    public static void a(com.kwad.sdk.api.loader.a.C0495a c0495a, long j) {
        a(2, c0495a, j, 0, "");
    }

    public static void a(com.kwad.sdk.api.loader.a.C0495a c0495a, long j, String str) {
        a(3, c0495a, j, 0, str);
    }

    public static void a(com.kwad.sdk.api.loader.a.C0495a c0495a, int i, String str) {
        a(4, c0495a, 0L, i, str);
    }

    public static void b(com.kwad.sdk.api.loader.a.C0495a c0495a) {
        a(5, c0495a, 0L, 0, "");
    }

    public static void b(com.kwad.sdk.api.loader.a.C0495a c0495a, long j) {
        a(6, c0495a, j, 0, "");
    }

    public static void b(com.kwad.sdk.api.loader.a.C0495a c0495a, int i, String str) {
        a(7, c0495a, 0L, i, str);
    }

    private static void a(int i, com.kwad.sdk.api.loader.a.C0495a c0495a, long j, int i2, String str) {
        if (c0495a == null) {
            return;
        }
        try {
            JSONObject json = new a((byte) 0).df(i).dg(aIo).cZ(c0495a.sdkVersion).da(c0495a.aHF).as(j).dh(i2).db(str).toJson();
            new StringBuilder("status:").append(i).append("--jo:").append(json);
            com.kwad.sdk.api.c.g("reportDynamicUpdate", json);
        } catch (Throwable unused) {
        }
    }

    static class a {
        private int aIp;
        private int aIq;
        private String aIr;
        private String aIs;
        private long aIt;
        private int aIu;
        private String aIv;

        private a() {
        }

        /* synthetic */ a(byte b) {
            this();
        }

        /* JADX INFO: Access modifiers changed from: private */
        public a df(int i) {
            this.aIp = i;
            return this;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public a dg(int i) {
            this.aIq = i;
            return this;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public a cZ(String str) {
            this.aIr = str;
            return this;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public a da(String str) {
            this.aIs = str;
            return this;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public a as(long j) {
            this.aIt = j;
            return this;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public a dh(int i) {
            this.aIu = i;
            return this;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public a db(String str) {
            this.aIv = str;
            return this;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            try {
                jSONObject.putOpt("load_status", Integer.valueOf(this.aIp));
                jSONObject.putOpt("update_count", Integer.valueOf(this.aIq));
                jSONObject.putOpt("dynamic_version", this.aIr);
                jSONObject.putOpt("download_url", this.aIs);
                jSONObject.putOpt("duration_ms", Long.valueOf(this.aIt));
                jSONObject.putOpt("error_code", Integer.valueOf(this.aIu));
                jSONObject.putOpt("error_msg", this.aIv);
            } catch (Exception unused) {
            }
            return jSONObject;
        }

        public final String toString() {
            return "MonitorInfo{load_status=" + this.aIp + ", update_count=" + this.aIq + ", dynamic_version='" + this.aIr + "', download_url='" + this.aIs + "', duration_ms=" + this.aIt + ", error_code=" + this.aIu + ", error_msg='" + this.aIv + "'}";
        }
    }
}
