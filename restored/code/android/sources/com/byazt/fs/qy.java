package com.byazt.fs;

import android.graphics.Color;
import android.graphics.Rect;
import android.util.JsonReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 720, 110})
public class qy {
    public static com.byazt.zk.x c(com.byazt.ga.a aVar) {
        Rect rectUj = aVar.uj();
        return new com.byazt.zk.x(Collections.emptyList(), aVar, "__container", -1L, com.byazt.zk.x.c.PRE_COMP, -1L, null, Collections.emptyList(), new com.byazt.kd.t(), 0, 0, 0, 0.0f, 0.0f, rectUj.width(), rectUj.height(), null, null, Collections.emptyList(), com.byazt.zk.x.tt.NONE, null, false, null, null);
    }

    public static com.byazt.zk.x c(JsonReader jsonReader, com.byazt.ga.a aVar) throws IOException {
        com.byazt.zk.x.tt ttVar = com.byazt.zk.x.tt.NONE;
        ArrayList arrayList = new ArrayList();
        ArrayList arrayList2 = new ArrayList();
        jsonReader.beginObject();
        Float fValueOf = Float.valueOf(0.0f);
        Float fValueOf2 = Float.valueOf(1.0f);
        com.byazt.zk.x.tt ttVar2 = ttVar;
        com.byazt.zk.x.c cVar = null;
        String strNextString = null;
        com.byazt.kd.t tVarC = null;
        com.byazt.kd.da daVarA = null;
        com.byazt.kd.sl slVarC = null;
        com.byazt.kd.tt ttVarC = null;
        com.byazt.jx.c cVarC = null;
        da daVarC = null;
        long jNextInt = 0;
        int iNextInt = 0;
        int iNextInt2 = 0;
        int color = 0;
        boolean zNextBoolean = false;
        float fNextDouble = 0.0f;
        float fNextDouble2 = 0.0f;
        float fNextDouble3 = 0.0f;
        float fSp = 0.0f;
        long jNextInt2 = -1;
        float fNextDouble4 = 1.0f;
        String strNextString2 = "UNSET";
        String strNextString3 = null;
        float fNextDouble5 = 0.0f;
        while (jsonReader.hasNext()) {
            String strNextName = jsonReader.nextName();
            strNextName.hashCode();
            switch (strNextName) {
                case "parent":
                    jNextInt2 = jsonReader.nextInt();
                    break;
                case "shapes":
                    jsonReader.beginArray();
                    while (jsonReader.hasNext()) {
                        com.byazt.jx.ve veVarC = x.c(jsonReader, aVar);
                        if (veVarC != null) {
                            arrayList2.add(veVarC);
                        }
                    }
                    jsonReader.endArray();
                    break;
                case "h":
                    fNextDouble3 = (float) (jsonReader.nextDouble() * ((double) com.byazt.kk.da.c()));
                    break;
                case "t":
                    jsonReader.beginObject();
                    while (jsonReader.hasNext()) {
                        String strNextName2 = jsonReader.nextName();
                        strNextName2.hashCode();
                        if (strNextName2.equals("a")) {
                            jsonReader.beginArray();
                            if (jsonReader.hasNext()) {
                                slVarC = tt.c(jsonReader, aVar);
                            }
                            while (jsonReader.hasNext()) {
                                jsonReader.skipValue();
                            }
                            jsonReader.endArray();
                        } else if (strNextName2.equals(com.kuaishou.weapon.p0.t.t)) {
                            daVarA = uj.a(jsonReader, aVar);
                        } else {
                            jsonReader.skipValue();
                        }
                    }
                    jsonReader.endObject();
                    break;
                case "w":
                    fNextDouble2 = (float) (jsonReader.nextDouble() * ((double) com.byazt.kk.da.c()));
                    break;
                case "cl":
                    strNextString3 = jsonReader.nextString();
                    break;
                case "ef":
                    jsonReader.beginArray();
                    ArrayList arrayList3 = new ArrayList();
                    while (jsonReader.hasNext()) {
                        jsonReader.beginObject();
                        while (jsonReader.hasNext()) {
                            String strNextName3 = jsonReader.nextName();
                            strNextName3.hashCode();
                            if (strNextName3.equals("nm")) {
                                arrayList3.add(jsonReader.nextString());
                            } else if (strNextName3.equals(com.alipay.sdk.m.w.a.u)) {
                                int iNextInt3 = jsonReader.nextInt();
                                if (iNextInt3 == 29) {
                                    cVarC = n.c(jsonReader, aVar);
                                } else if (iNextInt3 == 25) {
                                    daVarC = new sl().c(jsonReader, aVar);
                                }
                            } else {
                                jsonReader.skipValue();
                            }
                        }
                        jsonReader.endObject();
                    }
                    jsonReader.endArray();
                    aVar.c("Lottie doesn't support layer effects. If you are using them for  fills, strokes, trim paths etc. then try adding them directly as contents  in your shape. Found: ".concat(String.valueOf(arrayList3)));
                    break;
                case "hd":
                    zNextBoolean = jsonReader.nextBoolean();
                    break;
                case "ip":
                    fNextDouble5 = (float) jsonReader.nextDouble();
                    break;
                case "ks":
                    tVarC = ve.c(jsonReader, aVar);
                    break;
                case "nm":
                    strNextString2 = jsonReader.nextString();
                    break;
                case "op":
                    fSp = (float) jsonReader.nextDouble();
                    break;
                case "sc":
                    color = Color.parseColor(jsonReader.nextString());
                    break;
                case "sh":
                    iNextInt2 = (int) (jsonReader.nextInt() * com.byazt.kk.da.c());
                    break;
                case "sr":
                    fNextDouble4 = (float) jsonReader.nextDouble();
                    break;
                case "st":
                    fNextDouble = (float) jsonReader.nextDouble();
                    break;
                case "sw":
                    iNextInt = (int) (jsonReader.nextInt() * com.byazt.kk.da.c());
                    break;
                case "tm":
                    ttVarC = uj.c(jsonReader, aVar, false);
                    break;
                case "tt":
                    int iNextInt4 = jsonReader.nextInt();
                    if (iNextInt4 >= com.byazt.zk.x.tt.values().length) {
                        aVar.c("Unsupported matte type: ".concat(String.valueOf(iNextInt4)));
                        break;
                    } else {
                        ttVar2 = com.byazt.zk.x.tt.values()[iNextInt4];
                        int i = AnonymousClass1.c[ttVar2.ordinal()];
                        if (i == 1) {
                            aVar.c("Unsupported matte type: Luma");
                        } else if (i == 2) {
                            aVar.c("Unsupported matte type: Luma Inverted");
                        }
                        aVar.c(1);
                        break;
                    }
                    break;
                case "ty":
                    int iNextInt5 = jsonReader.nextInt();
                    if (iNextInt5 < com.byazt.zk.x.c.UNKNOWN.ordinal()) {
                        cVar = com.byazt.zk.x.c.values()[iNextInt5];
                        break;
                    } else {
                        cVar = com.byazt.zk.x.c.UNKNOWN;
                        break;
                    }
                    break;
                case "ind":
                    jNextInt = jsonReader.nextInt();
                    break;
                case "refId":
                    strNextString = jsonReader.nextString();
                    break;
                case "masksProperties":
                    jsonReader.beginArray();
                    while (jsonReader.hasNext()) {
                        arrayList.add(gr.c(jsonReader, aVar));
                    }
                    aVar.c(arrayList.size());
                    jsonReader.endArray();
                    break;
                default:
                    jsonReader.skipValue();
                    break;
            }
        }
        jsonReader.endObject();
        ArrayList arrayList4 = new ArrayList();
        if (fNextDouble5 > 0.0f) {
            arrayList4.add(new com.byazt.vc.c(aVar, fValueOf, fValueOf, null, 0.0f, Float.valueOf(fNextDouble5)));
        }
        if (fSp <= 0.0f) {
            fSp = aVar.sp();
        }
        arrayList4.add(new com.byazt.vc.c(aVar, fValueOf2, fValueOf2, null, fNextDouble5, Float.valueOf(fSp)));
        arrayList4.add(new com.byazt.vc.c(aVar, fValueOf, fValueOf, null, fSp, Float.valueOf(Float.MAX_VALUE)));
        if (strNextString2.endsWith(".ai") || "ai".equals(strNextString3)) {
            aVar.c("Convert your Illustrator layers to shape layers.");
        }
        return new com.byazt.zk.x(arrayList2, aVar, strNextString2, jNextInt, cVar, jNextInt2, strNextString, arrayList, tVarC, iNextInt, iNextInt2, color, fNextDouble4, fNextDouble, fNextDouble2, fNextDouble3, daVarA, slVarC, arrayList4, ttVar2, ttVarC, zNextBoolean, cVarC, daVarC);
    }

    /* JADX INFO: renamed from: com.byazt.fs.qy$1, reason: invalid class name */
    @com.byazt.zqa.c(c = {0, 1, 720, 721})
    static /* synthetic */ class AnonymousClass1 {
        public static final /* synthetic */ int[] c;

        static {
            int[] iArr = new int[com.byazt.zk.x.tt.values().length];
            c = iArr;
            try {
                iArr[com.byazt.zk.x.tt.LUMA.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                c[com.byazt.zk.x.tt.LUMA_INVERTED.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
        }
    }
}
