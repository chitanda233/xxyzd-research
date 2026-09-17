package com.alipay.android.phone.mrpc.core.a;

import android.util.Log;
import com.alipay.android.phone.mrpc.core.RpcException;
import com.alipay.sdk.m.y.o;
import java.lang.reflect.Type;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class d extends a {
    public d(Type type, byte[] bArr) {
        super(type, bArr);
    }

    @Override // com.alipay.android.phone.mrpc.core.a.c
    public Object a() {
        try {
            String str = new String(this.b);
            Log.v("HttpCaller", "threadid = " + Thread.currentThread().getId() + "; rpc response:  " + str);
            JSONObject jSONObject = new JSONObject(str);
            int i = jSONObject.getInt(o.f393a);
            if (i == 1000) {
                return this.f175a == String.class ? jSONObject.optString(o.c) : com.alipay.sdk.m.f.a.a(jSONObject.optString(o.c), this.f175a);
            }
            throw new RpcException(Integer.valueOf(i), jSONObject.optString("tips"));
        } catch (Exception e) {
            throw new RpcException((Integer) 10, new StringBuilder("response  =").append(new String(this.b)).append(":").append(e).toString() == null ? "" : e.getMessage());
        }
    }
}
