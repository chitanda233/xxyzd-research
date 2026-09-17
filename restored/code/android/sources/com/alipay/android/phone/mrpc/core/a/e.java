package com.alipay.android.phone.mrpc.core.a;

import android.util.Log;
import com.alipay.android.phone.mrpc.core.RpcException;
import java.util.ArrayList;
import org.apache.http.client.utils.URLEncodedUtils;
import org.apache.http.message.BasicNameValuePair;

/* JADX INFO: loaded from: classes.dex */
public class e extends b {
    private int c;
    private Object d;

    public e(int i, String str, Object obj) {
        super(str, obj);
        this.c = i;
    }

    @Override // com.alipay.android.phone.mrpc.core.a.f
    public void a(Object obj) {
        this.d = obj;
    }

    @Override // com.alipay.android.phone.mrpc.core.a.f
    public byte[] a() {
        try {
            ArrayList arrayList = new ArrayList();
            if (this.d != null) {
                arrayList.add(new BasicNameValuePair("extParam", com.alipay.sdk.m.f.a.a(this.d)));
            }
            arrayList.add(new BasicNameValuePair("operationType", this.f176a));
            arrayList.add(new BasicNameValuePair("id", this.c + ""));
            Log.d("JsonSerializer", "mParams is:" + this.b);
            Object obj = this.b;
            arrayList.add(new BasicNameValuePair("requestData", obj == null ? "[]" : com.alipay.sdk.m.f.a.a(obj)));
            String str = URLEncodedUtils.format(arrayList, "utf-8");
            Log.i("JsonSerializer", "request = " + str);
            return str.getBytes();
        } catch (Exception e) {
            throw new RpcException(9, new StringBuilder("request  =").append(this.b).append(":").append(e).toString() != null ? e.getMessage() : "", e);
        }
    }
}
