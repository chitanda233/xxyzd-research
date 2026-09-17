package com.tencent.bugly.proguard;

import com.baidu.mobads.sdk.api.IAdInterListener;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;

/* JADX INFO: compiled from: BUGLY */
/* JADX INFO: loaded from: classes4.dex */
public final class a {
    /* JADX WARN: Code duplicated, block: B:55:0x00c5 A[PHI: r7
  0x00c5: PHI (r7v2 java.lang.String) = 
  (r7v1 java.lang.String)
  (r7v1 java.lang.String)
  (r7v3 java.lang.String)
  (r7v3 java.lang.String)
  (r7v4 java.lang.String)
  (r7v4 java.lang.String)
 binds: [B:21:0x0055, B:23:0x005b, B:26:0x0067, B:28:0x006d, B:36:0x0089, B:38:0x008f] A[DONT_GENERATE, DONT_INLINE]] */
    public static String a(ArrayList<String> arrayList) {
        StringBuffer stringBuffer = new StringBuffer();
        int i = 0;
        while (true) {
            String str = "map";
            if (i < arrayList.size()) {
                String str2 = arrayList.get(i);
                if (str2.equals("java.lang.Integer") || str2.equals(IAdInterListener.AdProdType.PRODUCT_INTERSTITIAL)) {
                    str = "int32";
                } else if (str2.equals("java.lang.Boolean") || str2.equals("boolean")) {
                    str = "bool";
                } else if (str2.equals("java.lang.Byte") || str2.equals("byte")) {
                    str = "char";
                } else {
                    String str3 = "double";
                    if (str2.equals("java.lang.Double") || str2.equals("double")) {
                        str = str3;
                    } else {
                        str3 = "float";
                        if (str2.equals("java.lang.Float") || str2.equals("float")) {
                            str = str3;
                        } else if (str2.equals("java.lang.Long") || str2.equals("long")) {
                            str = "int64";
                        } else {
                            str3 = "short";
                            if (str2.equals("java.lang.Short") || str2.equals("short")) {
                                str = str3;
                            } else {
                                if (str2.equals("java.lang.Character")) {
                                    throw new IllegalArgumentException("can not support java.lang.Character");
                                }
                                if (str2.equals("java.lang.String")) {
                                    str = "string";
                                } else if (str2.equals("java.util.List")) {
                                    str = "list";
                                } else if (!str2.equals("java.util.Map")) {
                                    str = str2;
                                }
                            }
                        }
                    }
                }
                arrayList.set(i, str);
                i++;
            } else {
                Collections.reverse(arrayList);
                for (int i2 = 0; i2 < arrayList.size(); i2++) {
                    String str4 = arrayList.get(i2);
                    if (str4.equals("list")) {
                        int i3 = i2 - 1;
                        arrayList.set(i3, "<" + arrayList.get(i3));
                        arrayList.set(0, arrayList.get(0) + ">");
                    } else if (str4.equals("map")) {
                        int i4 = i2 - 1;
                        arrayList.set(i4, "<" + arrayList.get(i4) + ",");
                        arrayList.set(0, arrayList.get(0) + ">");
                    } else if (str4.equals("Array")) {
                        int i5 = i2 - 1;
                        arrayList.set(i5, "<" + arrayList.get(i5));
                        arrayList.set(0, arrayList.get(0) + ">");
                    }
                }
                Collections.reverse(arrayList);
                Iterator<String> it = arrayList.iterator();
                while (it.hasNext()) {
                    stringBuffer.append(it.next());
                }
                return stringBuffer.toString();
            }
        }
    }
}
