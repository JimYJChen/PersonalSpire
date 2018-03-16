﻿namespace Spire.Doc.Core.DataStreamParser.Escher
{
    using System;

    internal enum EscherShapeType
    {
        msosptAccenrCallout1 = 0x2c,
        msosptAccentBorderCallout1 = 50,
        msosptAccentBorderCallout2 = 0x33,
        msosptAccentBorderCallout3 = 0x34,
        msosptAccentBorderCallout90 = 0xb5,
        msosptAccentCallout2 = 0x2d,
        msosptAccentCallout3 = 0x2e,
        msosptAccentCallout90 = 0xb3,
        msosptActionButtonBackPrevious = 0xc2,
        msosptActionButtonBeginning = 0xc4,
        msosptActionButtonBlank = 0xbd,
        msosptActionButtonDocument = 0xc6,
        msosptActionButtonEnd = 0xc3,
        msosptActionButtonForwardNext = 0xc1,
        msosptActionButtonHelp = 0xbf,
        msosptActionButtonHome = 190,
        msosptActionButtonInformation = 0xc0,
        msosptActionButtonMovie = 200,
        msosptActionButtonReturn = 0xc5,
        msosptActionButtonSound = 0xc7,
        msosptArc = 0x13,
        msosptArrow = 13,
        msosptBalloon = 0x11,
        msosptBentArrow = 0x5b,
        msosptBentConnector2 = 0x21,
        msosptBentConnector3 = 0x22,
        msosptBentConnector4 = 0x23,
        msosptBentConnector5 = 0x24,
        msosptBentUpArrow = 90,
        msosptBevel = 0x54,
        msosptBlockArc = 0x5f,
        msosptBorderCallout1 = 0x2f,
        msosptBorderCallout2 = 0x30,
        msosptBorderCallout3 = 0x31,
        msosptBorderCallout90 = 180,
        msosptBracePair = 0xba,
        msosptBracketPair = 0xb9,
        msosptCallout1 = 0x29,
        msosptCallout2 = 0x2a,
        msosptCallout3 = 0x2b,
        msosptCallout90 = 0xb2,
        msosptCan = 0x16,
        msosptChevron = 0x37,
        msosptCircularArrow = 0x63,
        msosptCloudCallout = 0x6a,
        msosptCube = 0x10,
        msosptCurvedConnector2 = 0x25,
        msosptCurvedConnector3 = 0x26,
        msosptCurvedConnector4 = 0x27,
        msosptCurvedConnector5 = 40,
        msosptCurvedDownArrow = 0x69,
        msosptCurvedLeftArrow = 0x67,
        msosptCurvedRightArrow = 0x66,
        msosptCurvedUpArrow = 0x68,
        msosptCustomShape = 100,
        msosptDiamond = 4,
        msosptDonut = 0x17,
        msosptDoubleWave = 0xbc,
        msosptDownArrow = 0x43,
        msosptDownArrowCallout = 80,
        msosptEllipse = 3,
        msosptEllipseRibbon = 0x6b,
        msosptEllipseRibbon2 = 0x6c,
        msosptFlowChartAlternateProcess = 0xb0,
        msosptFlowChartCollate = 0x7d,
        msosptFlowChartConnector = 120,
        msosptFlowChartDecision = 110,
        msosptFlowChartDelay = 0x87,
        msosptFlowChartDisplay = 0x86,
        msosptFlowChartDocument = 0x72,
        msosptFlowChartExtract = 0x7f,
        msosptFlowChartInputOutput = 0x6f,
        msosptFlowChartInternalStorage = 0x71,
        msosptFlowChartMagneticDisk = 0x84,
        msosptFlowChartMagneticDrum = 0x85,
        msosptFlowChartMagneticTape = 0x83,
        msosptFlowChartManualInput = 0x76,
        msosptFlowChartManualOperation = 0x77,
        msosptFlowChartMerge = 0x80,
        msosptFlowChartMultidocument = 0x73,
        msosptFlowChartOfflineStorage = 0x81,
        msosptFlowChartOffpageConnector = 0xb1,
        msosptFlowChartOnlineStorage = 130,
        msosptFlowChartOr = 0x7c,
        msosptFlowChartPredefinedProcess = 0x70,
        msosptFlowChartPreparation = 0x75,
        msosptFlowChartProcess = 0x6d,
        msosptFlowChartPunchedCard = 0x79,
        msosptFlowChartPunchedTape = 0x7a,
        msosptFlowChartSort = 0x7e,
        msosptFlowChartSummingJunction = 0x7b,
        msosptFlowChartTerminator = 0x74,
        msosptFoldedCorner = 0x41,
        msosptGroup = -1,
        msosptHeart = 0x4a,
        msosptHexagon = 9,
        msosptHomePlate = 15,
        msosptHorizontalScroll = 0x62,
        msosptHostControl = 0xc9,
        msosptIrregularSeal1 = 0x47,
        msosptIrregularSeal2 = 0x48,
        msosptLeftArrow = 0x42,
        msosptLeftArrowCallout = 0x4d,
        msosptLeftBrace = 0x57,
        msosptLeftBracket = 0x55,
        msosptLeftRightArrow = 0x45,
        msosptLeftRightArrowCallout = 0x51,
        msosptLeftRightUpArrow = 0xb6,
        msosptLeftUpArrow = 0x59,
        msosptLightningBolt = 0x49,
        msosptLine = 20,
        msosptMin = 0,
        msosptMoon = 0xb8,
        msosptNoSmoking = 0x39,
        msosptNotchedRightArrow = 0x5e,
        msosptOctagon = 10,
        msosptOleControl = -3,
        msosptOleObject = -2,
        msosptParallelogram = 7,
        msosptPentagon = 0x38,
        msosptPictureFrame = 0x4b,
        msosptPlaque = 0x15,
        msosptPlus = 11,
        msosptQuadArrow = 0x4c,
        msosptQuadArrowCallout = 0x53,
        msosptRectangle = 1,
        msosptRibbon = 0x35,
        msosptRibbon2 = 0x36,
        msosptRightArrowCallout = 0x4e,
        msosptRightBrace = 0x58,
        msosptRightBracket = 0x56,
        msosptRightTriangle = 6,
        msosptRoundRectangle = 2,
        msosptSeal = 0x12,
        msosptSeal16 = 0x3b,
        msosptSeal24 = 0x5c,
        msosptSeal32 = 60,
        msosptSeal4 = 0xbb,
        msosptSeal8 = 0x3a,
        msosptSmileyFace = 0x60,
        msosptStar = 12,
        msosptStraightConnector1 = 0x20,
        msosptStripedRightArrow = 0x5d,
        msosptSun = 0xb7,
        msosptTextArchDownCurve = 0x91,
        msosptTextArchDownPour = 0x95,
        msosptTextArchUpCurve = 0x90,
        msosptTextArchUpPour = 0x94,
        msosptTextBox = 0xca,
        msosptTextButtonCurve = 0x93,
        msosptTextButtonPour = 0x97,
        msosptTextCanDown = 0xaf,
        msosptTextCanUp = 0xae,
        msosptTextCascadeDown = 0x9b,
        msosptTextCascadeUp = 0x9a,
        msosptTextChevron = 140,
        msosptTextChevronInverted = 0x8d,
        msosptTextCircleCurve = 0x92,
        msosptTextCirclePour = 150,
        msosptTextCurve = 0x1b,
        msosptTextCurveDown = 0x99,
        msosptTextCurveUp = 0x98,
        msosptTextDeflate = 0xa1,
        msosptTextDeflateBottom = 0xa3,
        msosptTextDeflateInflate = 0xa6,
        msosptTextDeflateInflateDeflate = 0xa7,
        msosptTextDeflateTop = 0xa5,
        msosptTextFadeDown = 0xab,
        msosptTextFadeLeft = 0xa9,
        msosptTextFadeRight = 0xa8,
        msosptTextFadeUp = 170,
        msosptTextHexagon = 0x1a,
        msosptTextInflate = 160,
        msosptTextInflateBottom = 0xa2,
        msosptTextInflateTop = 0xa4,
        msosptTextOctagon = 0x19,
        msosptTextOnCurve = 30,
        msosptTextOnRing = 0x1f,
        msosptTextPlainText = 0x88,
        msosptTextRing = 0x1d,
        msosptTextRingInside = 0x8e,
        msosptTextRingOutside = 0x8f,
        msosptTextSimple = 0x18,
        msosptTextSlantDown = 0xad,
        msosptTextSlantUp = 0xac,
        msosptTextStop = 0x89,
        msosptTextTriangle = 0x8a,
        msosptTextTriangleInverted = 0x8b,
        msosptTextWave = 0x1c,
        msosptTextWave1 = 0x9c,
        msosptTextWave2 = 0x9d,
        msosptTextWave3 = 0x9e,
        msosptTextWave4 = 0x9f,
        msosptThickArrow = 14,
        msosptTrapezoid = 8,
        msosptTriangle = 5,
        msosptUpArrow = 0x44,
        msosptUpArrowCallout = 0x4f,
        msosptUpDownArrow = 70,
        msosptUpDownArrowCallout = 0x52,
        msosptUturnArrow = 0x65,
        msosptVerticalScroll = 0x61,
        msosptWave = 0x40,
        msosptWedgeEllipseCallout = 0x3f,
        msosptWedgeRectCallout = 0x3d,
        msosptWedgeRRectCallout = 0x3e
    }
}
