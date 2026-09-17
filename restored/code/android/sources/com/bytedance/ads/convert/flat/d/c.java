package com.bytedance.ads.convert.flat.d;

import com.bytedance.ads.convert.flat.a.i;
import java.util.Arrays;
import java.util.HashMap;
import kotlin.Lazy;
import kotlin.LazyKt;
import kotlin.Pair;
import kotlin.TuplesKt;
import kotlin.collections.MapsKt;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public final class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f1689a;
    public String b;
    public String c;
    public String d;
    public JSONArray e;
    public int[] f;
    public i g;
    public final Lazy h;
    public final Lazy i;

    public static final class a extends Lambda implements Function0<HashMap<String, Object>> {
        public a() {
            super(0);
        }

        @Override // kotlin.jvm.functions.Function0
        public HashMap<String, Object> invoke() {
            Pair[] pairArr = new Pair[7];
            pairArr[0] = TuplesKt.to("client_tun", c.this.f1689a);
            pairArr[1] = TuplesKt.to("disk", c.this.b);
            pairArr[2] = TuplesKt.to("memory", c.this.c);
            pairArr[3] = TuplesKt.to("boot_time_sec", c.this.d);
            i iVar = c.this.g;
            pairArr[4] = TuplesKt.to("u_t", iVar != null ? iVar.a() : new JSONObject());
            pairArr[5] = TuplesKt.to("pkg_info", c.this.e);
            String string = Arrays.toString(c.this.f);
            Intrinsics.checkNotNullExpressionValue(string, "java.util.Arrays.toString(this)");
            pairArr[6] = TuplesKt.to("inode", string);
            return MapsKt.hashMapOf(pairArr);
        }
    }

    public static final class b extends Lambda implements Function0<JSONObject> {
        public b() {
            super(0);
        }

        @Override // kotlin.jvm.functions.Function0
        public JSONObject invoke() throws JSONException {
            JSONObject jSONObject = new JSONObject();
            jSONObject.put("client_tun", c.this.f1689a);
            jSONObject.put("disk", c.this.b);
            jSONObject.put("memory", c.this.c);
            jSONObject.put("boot_time_sec", c.this.d);
            i iVar = c.this.g;
            jSONObject.put("u_t", iVar != null ? iVar.a() : null);
            jSONObject.put("pkg_info", c.this.e);
            String string = Arrays.toString(c.this.f);
            Intrinsics.checkNotNullExpressionValue(string, "java.util.Arrays.toString(this)");
            jSONObject.put("inode", string);
            return jSONObject;
        }
    }

    public c() {
        this.f1689a = "";
        this.b = "";
        this.c = "";
        this.d = "";
        this.e = new JSONArray();
        this.f = new int[0];
        this.h = LazyKt.lazy(new b());
        this.i = LazyKt.lazy(new a());
    }

    public c(c zDataModel) throws JSONException {
        Intrinsics.checkNotNullParameter(zDataModel, "zDataModel");
        this.f1689a = "";
        this.b = "";
        this.c = "";
        this.d = "";
        this.e = new JSONArray();
        this.f = new int[0];
        this.h = LazyKt.lazy(new b());
        this.i = LazyKt.lazy(new a());
        this.f1689a = zDataModel.f1689a;
        this.b = zDataModel.b;
        this.c = zDataModel.c;
        this.d = zDataModel.d;
        this.e = zDataModel.e;
        this.f = zDataModel.f;
        a(this.g);
    }

    public final void a(i iVar) throws JSONException {
        ((JSONObject) this.h.getValue()).put("u_t", iVar != null ? iVar.a() : null);
        ((HashMap) this.i.getValue()).put("u_t", iVar != null ? iVar.a() : new JSONObject());
        this.g = iVar;
    }
}
