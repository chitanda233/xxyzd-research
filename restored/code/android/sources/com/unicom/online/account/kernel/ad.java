package com.unicom.online.account.kernel;

import java.security.SecureRandom;
import org.bouncycastle.crypto.InvalidCipherTextException;
import org.bouncycastle.crypto.engines.SM2Engine;
import org.bouncycastle.crypto.params.ECPublicKeyParameters;
import org.bouncycastle.crypto.params.ParametersWithRandom;
import org.bouncycastle.jce.provider.BouncyCastleProvider;

/* JADX INFO: loaded from: classes4.dex */
public abstract class ad {
    public static final ba b = new ba();
    public static final bc c;

    static {
        bc.b = new BouncyCastleProvider();
        c = new bc();
    }

    public static byte[] b(byte[] bArr, byte[] bArr2) throws bd {
        b.getClass();
        if (bArr == null) {
            throw new bd(10);
        }
        if (bArr.length == 0) {
            throw new bd(18);
        }
        if (bArr2.length != 65) {
            throw new bd(20);
        }
        if (bArr2[0] != 4) {
            throw new bd(11);
        }
        try {
            ECPublicKeyParameters eCPublicKeyParametersB = ba.b(bArr2);
            SM2Engine sM2Engine = new SM2Engine();
            sM2Engine.init(true, new ParametersWithRandom(eCPublicKeyParametersB, new SecureRandom()));
            try {
                byte[] bArrProcessBlock = sM2Engine.processBlock(bArr, 0, bArr.length);
                if (bArrProcessBlock == null || bArrProcessBlock.length < 97) {
                    throw new bd(13);
                }
                byte[] bArr3 = new byte[bArrProcessBlock.length];
                System.arraycopy(bArrProcessBlock, 0, bArr3, 0, 65);
                System.arraycopy(bArrProcessBlock, bArrProcessBlock.length - 32, bArr3, 65, 32);
                System.arraycopy(bArrProcessBlock, 65, bArr3, 97, bArrProcessBlock.length - 97);
                return bArr3;
            } catch (InvalidCipherTextException e) {
                throw new bd(4, e);
            }
        } catch (Exception unused) {
            throw new bd(19);
        }
    }
}
