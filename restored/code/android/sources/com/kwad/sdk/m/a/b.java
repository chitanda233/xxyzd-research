package com.kwad.sdk.m.a;

import android.text.TextUtils;
import android.util.Log;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.utils.ab;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    public static final String TAG = "Ranger_b";
    public Object bne;
    public String bnf;
    public String bng;
    public boolean bnh;
    public String bni;
    public C0531b bnj;
    public b bnk;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public String bnl;
        public String bnm;
        public String bnn;
        public List<String> bno;
        public List<a> bnp = new ArrayList();
        public Object bnq;
        public List<Object> bnr;
        public String className;
        public String fieldName;

        public final Object getValue() {
            if (!TextUtils.isEmpty(this.bnl) || !TextUtils.isEmpty(this.bnn)) {
                return TZ();
            }
            return TY();
        }

        private Object TY() {
            Object objHJ = null;
            try {
                if (TextUtils.isEmpty(this.className)) {
                    c.w(b.TAG, "SpecialParam className is null");
                    return null;
                }
                objHJ = ab.hJ(this.className);
                c.d(b.TAG, "Class.forName(className):" + this.className + " value:" + objHJ);
                List<a> list = this.bnp;
                if (list != null && !list.isEmpty()) {
                    for (a aVar : this.bnp) {
                        aVar.bnq = objHJ;
                        c.d(b.TAG, "param.ob:" + aVar.bnq);
                        try {
                            ab.a(aVar.bnq, aVar.fieldName, aVar.getValue());
                        } catch (Exception e) {
                            c.d(b.TAG, Log.getStackTraceString(e));
                        }
                    }
                }
                c.d(b.TAG, "return value in special:" + objHJ);
                return objHJ;
            } catch (Exception e2) {
                c.d(b.TAG, Log.getStackTraceString(e2));
            }
        }

        private Object TZ() {
            if (TextUtils.isEmpty(this.bnn)) {
                return aq(this.bnl, this.bnm);
            }
            this.bnr = new ArrayList();
            Iterator<String> it = this.bno.iterator();
            while (it.hasNext()) {
                Object objAq = aq(this.bnn, it.next());
                if (objAq != null) {
                    this.bnr.add(objAq);
                }
            }
            return this.bnr;
        }

        private static Object aq(String str, String str2) {
            Object objValueOf = null;
            try {
                Class<?> cls = Class.forName(str);
                if (cls == Integer.class) {
                    objValueOf = Integer.valueOf(Integer.parseInt(str2));
                } else if (cls == Long.class) {
                    objValueOf = Long.valueOf(Long.parseLong(str2));
                } else if (cls == Float.class) {
                    objValueOf = Float.valueOf(Float.parseFloat(str2));
                } else if (cls == Boolean.class) {
                    objValueOf = Boolean.valueOf(Boolean.parseBoolean(str2));
                } else if (cls == Double.class) {
                    objValueOf = Double.valueOf(Double.parseDouble(str2));
                } else {
                    if (cls != String.class) {
                        str2 = null;
                    }
                    objValueOf = str2;
                }
            } catch (Exception e) {
                c.w(b.TAG, Log.getStackTraceString(e));
            }
            return objValueOf;
        }
    }

    /* JADX INFO: renamed from: com.kwad.sdk.m.a.b$b, reason: collision with other inner class name */
    public static class C0531b extends com.kwad.sdk.core.response.a.a {
        public boolean bns;
        public List<a> bnt;
        public Object[] bnu;
        public String name;

        public final Object[] Ua() {
            List<a> list = this.bnt;
            if (list == null || list.isEmpty()) {
                return null;
            }
            Object[] objArr = new Object[this.bnt.size()];
            for (int i = 0; i < this.bnt.size(); i++) {
                objArr[i] = this.bnt.get(i).getValue();
            }
            return objArr;
        }

        public final boolean TX() {
            if (!TextUtils.isEmpty(this.name)) {
                return false;
            }
            List<a> list = this.bnt;
            return (list == null || list.isEmpty()) && this.bnu == null;
        }
    }

    public final boolean TX() {
        if (this.bne != null || !TextUtils.isEmpty(this.bnf) || !TextUtils.isEmpty(this.bng) || !TextUtils.isEmpty(this.bni)) {
            return false;
        }
        C0531b c0531b = this.bnj;
        if (c0531b != null && !c0531b.TX()) {
            return false;
        }
        b bVar = this.bnk;
        return bVar == null || bVar.TX();
    }
}
